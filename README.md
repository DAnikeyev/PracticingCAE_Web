# CAE Practice — C1 trainer

A Blazor web app for practising the **Cambridge C1 Advanced (CAE) Reading & Use of
English** paper and English grammar/vocabulary topics.

- **Reading & Use of English Parts 1–4** in exam format: multiple-choice cloze,
  open cloze, word formation and key word transformations.
- **Topic drills** for focused practice: articles, prepositions, phrasal verbs,
  verb patterns, tenses, conditionals, modals, passive voice, reported speech,
  linking words, confusable words, collocations, relative clauses, quantifiers
  and word formation.
- Every task offers **110+ sets** (8 questions per set, 6 for Part 4) with
  **hints and answer explanations**.
- **Set generation prefers unseen sets**: each new set is one you haven't practised
  before, until the bank is exhausted — then the least recently seen sets return.
- **Progress tracking** with optional accounts: practise anonymously (progress is
  kept in your browser), register/login and your history moves with your account.
  The progress page shows accuracy over time per task, mistake statistics and
  your full practice history.
- Deployable with **docker-compose** (single service + a volume for the SQLite
  database).

## Quick start

### Run locally

```bash
dotnet run --project src/PracticingCAE.Web
```

Requires the .NET 8 SDK. The app creates a SQLite database at `src/PracticingCAE.Web/Data/app.db`
and applies migrations automatically on first start.

### Run with docker-compose

```bash
docker compose up --build
```

Then open http://localhost:8088. Progress data persists in the `cae-data` volume
(mounted at `/data` inside the container) — the database is created and migrated
automatically on first start, so users, attempts and stats survive restarts and upgrades.

The container port is bound to `127.0.0.1` — put a reverse proxy in front of it for
public traffic (see below). `ASPNETCORE_FORWARDEDHEADERS_ENABLED=true` is already set
so auth redirects keep https behind a proxy.

### Deploying behind nginx (production)

The app speaks plain HTTP on 8080; terminate TLS in nginx. WebSocket support is
required for Blazor Server circuits:

```nginx
server {
    listen 80;
    server_name cae.example.com;

    location / {
        proxy_pass         http://127.0.0.1:8088;
        proxy_http_version 1.1;
        proxy_set_header   Upgrade $http_upgrade;
        proxy_set_header   Connection "upgrade";
        proxy_set_header   Host $host;
        proxy_set_header   X-Real-IP $remote_addr;
        proxy_set_header   X-Forwarded-For $proxy_add_x_forwarded_for;
        proxy_set_header   X-Forwarded-Proto $scheme;
        proxy_read_timeout 3600s;   # Blazor circuit lifetime
        proxy_buffering    off;
    }
}
```

Then `certbot --nginx -d cae.example.com` for TLS. This site is deployed exactly this
way at `cae.ash-twin.com` (docker context `myvps` + nginx + Let's Encrypt).

## Repository layout

| Path | What |
|---|---|
| `src/PracticingCAE.Web` | The Blazor web app (Server interactivity, ASP.NET Identity) |
| `src/PracticingCAE.Web/Services` | Content loader, answer checker, set selector, progress service |
| `content/tasks/` | Task definitions (one JSON per task: id, kind, title, description) |
| `content/sets/` | The practice bank — one JSON file per set, grouped by task |
| `tools/ContentGen/` | Generator that validates seed banks and emits `content/` |
| `tools/ContentGen/Seeds/` | Curated seed banks (the human-editable source of content) |
| `tests/PracticingCAE.Tests` | Unit tests, including validation of the whole content bank |

## Content format

Each set file in `content/sets/<taskId>/` looks like:

```json
{
  "id": "rue-part1-0001",
  "taskId": "rue-part1",
  "source": "exam-style",
  "text": "The forest is {{1}} to many rare animals …",
  "gaps": [
    {
      "answer": "home",
      "options": ["home", "house", "place", "space"],
      "hint": "be ___ to = habitat of",
      "explanation": "'be home to' = be the place where something lives."
    }
  ]
}
```

- Cloze texts (Parts 1–3) use `{{n}}` markers; topic drills and Part 4 items use
  a `sentence` field with a single `___`.
- Part 3 gaps carry a `base` word (shown in capitals); Part 4 items carry a
  `keyword`, `lead` sentence and accepted `answers`.
- **Every gap has a hint and an explanation** — enforced by the generator and by
  a unit test over the whole bank.

### Adding content

Edit the seed banks in `tools/ContentGen/Seeds/` (plain JSON arrays), then:

```bash
dotnet run --project tools/ContentGen
```

The generator validates every item (answers present in options, exactly one gap
per sentence, hints and explanations present, unique ids) and rewrites
`content/`. It fails loudly if a task would have fewer than 100 sets.

## Tests

```bash
dotnet test
```

Covers the answer checker (normalisation, accepted variants), the set selector
(unseen-first policy), progress aggregation (accuracy, revealed-attempt
exclusion, anonymous adoption) and the **entire content bank** (schema,
answers-in-options, marker counts, the 100-sets-per-task bar).

## Configuration

| Variable | Meaning | Default |
|---|---|---|
| `DATA_DIR` | Directory for the SQLite database | `Data/` (dev) / `/data` (container) |
| `CONTENT_DIR` | Where to load practice content from | `<repo>/content` |
| `ASPNETCORE_URLS` | Bind address | dev profile / `http://+:8080` (container) |

Auth is standard ASP.NET Identity (individual accounts, email confirmation
disabled — register and play). Accounts are optional: anonymous progress is
tracked against a browser-local id and adopted into your account when you
register or log in.

## Content provenance

All practice content is original, written for this project (see the seed banks).
It follows the CAE exam formats but does not reproduce Cambridge exam material.
