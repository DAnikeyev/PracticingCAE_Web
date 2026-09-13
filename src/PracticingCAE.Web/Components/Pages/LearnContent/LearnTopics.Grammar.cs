using static PracticingCAE.Web.Components.Pages.LearnContent.LearnBlock;
using static PracticingCAE.Web.Components.Pages.LearnContent.LearnText;

namespace PracticingCAE.Web.Components.Pages.LearnContent;

/// <summary>Grammar cheat sheets, in canonical order.</summary>
public static class GrammarTopics
{
    // ------------------------------------------------------------------ articles

    private static readonly LearnLibrary.Topic Articles = new(
        "articles", "Articles", "a/an, the or nothing: decision rules, institutions, geography, traps.", "Grammar",
        new LearnSection(
            "Decision route",
            new Para("One question decides almost everything: **do the speaker and listener both know exactly which one?** Yes, use **the**. No, use **a/an** (countable singular) or **zero article** (plurals, uncountables)."),
            new Table(
                ["Choice", "Use it when", "Examples"],
                R("**a/an**", "first mention; one of many; jobs and rates", "*She works as a nurse. I need an umbrella. It costs two euros a kilo.*"),
                R("**the**", "already mentioned; only one in context; unique things; superlatives and ordinals", "*The car we hired broke down. The moon. It was the best day of my life.*"),
                R("**zero**", "general plurals and uncountables; languages; most meals; sports", "*Dogs are loyal. Coffee keeps me awake. Have lunch. She speaks Spanish.*")
            )
        ),
        new LearnSection(
            "a or an: sound, not spelling",
            new Bullets(
                "**an** before a vowel *sound*: *an hour, an honest man, an MP, an SOS*",
                "**a** before a consonant *sound*: *a university, a one-way ticket, a European city, a U-turn*",
                "Abbreviations follow the sound: *an FBI agent* but *a BA degree*."
            )
        ),
        new LearnSection(
            "Institutions: school, prison, hospital…",
            new Para("**Zero article** = the institution's purpose. **The** = the building as a place."),
            new Table(
                ["Expression", "Meaning", "Example"],
                R("go to prison / in prison", "as a prisoner", "*He was sent to prison for fraud.*"),
                R("at the prison", "visiting or working there", "*She gave a talk at the prison.*"),
                R("in hospital (BrE)", "as a patient", "*He's in hospital after the crash.*"),
                R("at school / at university", "as a student", "*Their kids are still at school.*"),
                R("go to bed / in bed", "to sleep", "*I went to bed at midnight.*"),
                R("at work", "working — *work* here never takes an article", "*Sorry, she's at work.*")
            )
        ),
        new LearnSection(
            "Geography",
            new Table(
                ["Zero article", "The"],
                R("most countries, states, cities, continents: *France, Tokyo, Asia*", "rivers, seas, oceans, canals: *the Danube, the Baltic, the Panama Canal*"),
                R("single lakes and mountains: *Lake Como, Mount Etna*", "mountain ranges and island groups: *the Alps, the Canaries*"),
                R("most street and place names: *Oxford Street, Victoria Station*", "plural or union names: *the Netherlands, the USA, the UAE*"),
                R("—", "a few fixed cases: *the Hague, the Amazon, the Gambia*")
            )
        ),
        new LearnSection(
            "Tricky cases",
            new Bullets(
                "Superlatives, ordinals, *only* and *same* take **the**: *the tallest, the first, the only one, the same*.",
                "**a most** = very: *It was a most convincing argument.*",
                "*most people* (general) vs *most of the people* (a specific group).",
                "Unique things take **the**: *the internet, the economy, the weather*.",
                "Neither word: *in bed, at home, by car, on foot* — but *in the car, on the bus*."
            ),
            new DoDont(
                ["*He was elected president.* (unique role)", "*She's at university studying law.*", "*in hospital* (BrE, as a patient)"],
                ["*He was elected a president.*", "*She's at the university studying law.*", "*in the hospital* (BrE usage)"])
        )
    );

    // ------------------------------------------------------------------ tenses

    private static readonly LearnLibrary.Topic Tenses = new(
        "tenses", "Tenses", "All twelve tenses on one page: form, core use and the signal words that give them away.", "Grammar",
        new LearnSection(
            "The twelve tenses",
            new Table(
                ["Tense", "Form", "Core use", "Signal words"],
                R("Present simple", "*works / does not work*", "habits, facts, timetables", "always, usually, every day, never, on Mondays"),
                R("Present continuous", "*is working*", "happening now; temporary; fixed arrangement; annoying habit with *always*", "now, at the moment, this week, Look!"),
                R("Present perfect", "*has worked*", "past action with present result; experience; unfinished time", "just, already, yet, ever, never, since, for, so far"),
                R("Present perfect cont.", "*has been working*", "activity continuing up to now; recent activity with visible evidence", "for, since, all day, How long…?"),
                R("Past simple", "*worked*", "finished action at a finished time", "yesterday, ago, in 2019, last week"),
                R("Past continuous", "*was working*", "background or interrupted past action", "while, as, at 8 pm yesterday"),
                R("Past perfect", "*had worked*", "the earlier of two past events", "before, by the time, after, already"),
                R("Past perfect cont.", "*had been working*", "duration up to a past point", "for two hours before…, had been -ing when…"),
                R("Future simple", "*will work*", "predictions, promises, instant decisions", "probably, I think, tomorrow"),
                R("Future continuous", "*will be working*", "in progress at a future time; planned future", "this time tomorrow, at 5 pm on Monday"),
                R("Future perfect", "*will have worked*", "completed by a future point", "by Monday, by 2030, by then"),
                R("Future perfect cont.", "*will have been working*", "duration up to a future point", "*By June I **will have been working** here for ten years.*")
            )
        ),
        new LearnSection(
            "Present perfect vs past simple",
            new Bullets(
                "Present perfect: the time is unfinished or unimportant, the result matters now — *I have lost my keys* (still lost).",
                "Past simple: the time is finished and usually stated — *I lost them yesterday*.",
                "*for* + period works with both; *since* + point in time needs a perfect form.",
                "*gone to* = still there; *been to* = visited and returned."
            )
        ),
        new LearnSection(
            "Continuous or not?",
            new Note("State verbs — *know, believe, own, belong, seem, mean, contain, prefer* — are not normally used in continuous forms. Some verbs change meaning: *I have a car / I'm having dinner; I think it's fine / I'm thinking about it; I see what you mean / I'm seeing the dentist at four.*")
        ),
        new LearnSection(
            "Ways of talking about the future",
            new Bullets(
                "**will**: prediction, promise, decision made while speaking.",
                "**be going to**: plan already made, or visible evidence — *Look at those clouds. It's going to rain.*",
                "**Present continuous**: fixed arrangement — *We're flying to Rome on Monday.*",
                "**Present simple**: timetables and programmes — *The train leaves at 6.40.*"
            )
        )
    );

    // ------------------------------------------------------------------ conditionals

    private static readonly LearnLibrary.Topic Conditionals = new(
        "conditionals", "Conditionals", "Zero to third and mixed patterns, wish-forms and inverted conditionals.", "Grammar",
        new LearnSection(
            "The five patterns",
            new Table(
                ["Type", "If-clause", "Main clause", "Meaning", "Example"],
                R("Zero", "present simple", "present simple", "general truth, result always follows", "*If you heat ice, it melts.*"),
                R("First", "present simple", "will / can / might / imperative", "real future possibility", "*If it rains, we'll take a taxi.*"),
                R("Second", "past simple", "would / could / might + base", "unreal present or unlikely future", "*If I had more time, I would learn Greek.*"),
                R("Third", "past perfect", "would have + V3", "unreal past; regret", "*If she had revised, she would have passed.*"),
                R("Mixed", "past perfect", "would + base", "past cause, present result", "*If I had taken that job, I would be rich now.*")
            ),
            new Note("Never put **will** or **would** in the if-clause: *~~If it will rain…~~* Use *If it rains… / If it rained…* The exception is *will* as a polite request: *If you will sign here…*")
        ),
        new LearnSection(
            "wish and if only",
            new Table(
                ["Form", "Use", "Example"],
                R("wish / if only + past simple", "regret about the present", "*I wish I knew the answer.*"),
                R("wish / if only + past perfect", "regret about the past", "*If only I had booked earlier!*"),
                R("wish + would", "annoyance; wanting someone else to change", "*I wish you would stop tapping your pen.*"),
                R("wish + could", "regret about ability", "*I wish I could sing.*"),
                R("would rather + past", "wanting someone else to act differently", "*I'd rather you didn't smoke in here.*"),
                R("it's (high) time + past", "something should already be happening", "*It's time we left.*")
            ),
            new Para("*I wish I were…* is the traditional form; *was* is common in speech.")
        ),
        new LearnSection(
            "Inverted conditionals (formal)",
            new Table(
                ["Plain", "Inverted"],
                R("*If you should need help, call me.*", "**Should you need help,** call me."),
                R("*If I had known, I would have come.*", "**Had I known,** I would have come."),
                R("*If it were not for your support…*", "**Were it not for** your support…"),
                R("*If he had not been so tired…*", "**Had he not been** so tired…")
            )
        ),
        new LearnSection(
            "Words that behave like if",
            new Bullets(
                "**unless** = if…not: *Unless you hurry, we'll miss it.*",
                "**provided (that) / as long as / on condition that** = only if: *You can stay as long as you keep quiet.*",
                "**in case** + present = precaution, not condition: *Take a jacket in case it gets cold.* Compare *I'll take a taxi if it gets cold.*",
                "**otherwise / or (else)** = if not: *Leave now, otherwise you'll be late.*"
            )
        )
    );

    // ------------------------------------------------------------------ verb patterns

    private static readonly LearnLibrary.Topic VerbPatterns = new(
        "verb-patterns", "Verb patterns", "-ing or to-infinitive, verbs that change meaning, and make / let / help.", "Grammar",
        new LearnSection(
            "Verb + -ing",
            new Bullets(
                "enjoy, avoid, mind, suggest, admit, deny, risk, postpone, consider, fancy, practise, keep, appreciate, involve, justify",
                "can't stand, can't help, can't face, it's worth, it's no use, there's no point (in)",
                "look forward to, be used to, get used to, object to, insist on, succeed in — prepositions always take -ing"
            )
        ),
        new LearnSection(
            "Verb + to-infinitive",
            new Bullets(
                "decide, hope, manage, offer, refuse, afford, agree, arrange, deserve, fail, promise, threaten, claim, seem, tend, appear, pretend, dare, happen",
                "Note the contrast: *look forward to **seeing** you* but *hope **to see** you*."
            )
        ),
        new LearnSection(
            "Verb + object + to-infinitive",
            new Para("want, ask, tell, order, advise, remind, persuade, encourage, enable, force, allow, expect, warn: *I persuaded her **to stay**.*"),
            new Note("*suggest* and *insist* do **not** take an object: *~~She suggested us to leave.~~* Say *She suggested **that we leave** / She suggested **leaving**.*")
        ),
        new LearnSection(
            "Both patterns possible",
            new Para("like, love, hate, prefer, start, begin, continue, intend — no real change of meaning. But *would like / would love / would prefer* always take the to-infinitive: *I'd like **to sit** here.*")
        ),
        new LearnSection(
            "Verbs that change meaning",
            new Table(
                ["Verb", "+ -ing", "+ to-infinitive"],
                R("stop", "*stop smoking* = quit", "*stop to smoke* = pause in order to smoke"),
                R("remember", "*remember locking* = memory of an earlier action", "*remember to lock* = not forget to do it"),
                R("forget", "*forget posting* = forgot that it happened", "*forget to post* = failed to do it"),
                R("regret", "*regret saying* = repent of it", "*regret to say* = polite formula for bad news"),
                R("try", "*try restarting* = do it as an experiment", "*try to restart* = make an effort"),
                R("mean", "*mean waiting* = involve", "*mean to say* = intend")
            )
        ),
        new LearnSection(
            "make, let, help",
            new Bullets(
                "**make sb do** — bare infinitive: *They made me wait.* Passive: *I was made **to wait**.*",
                "**let sb do** — bare infinitive, never *let to*: *Let me go.*",
                "**allow sb to do** = let: *We were allowed to leave early.*",
                "**help sb (to) do** — both forms are correct."
            )
        )
    );

    // ------------------------------------------------------------------ modals

    private static readonly LearnLibrary.Topic Modals = new(
        "modals", "Modals", "Deduction, obligation, prohibition and advice — the modal meanings C1 keeps testing.", "Grammar",
        new LearnSection(
            "Deduction: must, can't, might",
            new Table(
                ["Modal", "Certainty", "Example"],
                R("must be / must have done", "sure it is (was) true", "*He must be exhausted — he drove all night. She must have missed the bus.*"),
                R("can't be / couldn't have done", "sure it is (was) false", "*It can't be true — she was with me all day.*"),
                R("might / may / could (have done)", "possible", "*He might have taken the wrong train.*")
            ),
            new Note("The opposite of *must* (deduction) is **can't**, not *~~mustn't~~*.")
        ),
        new LearnSection(
            "Obligation and prohibition",
            new Table(
                ["Form", "Meaning", "Example"],
                R("must", "obligation from the speaker", "*I must remember to phone Mum.*"),
                R("have to / has to", "obligation from outside rules", "*You have to wear a helmet.*"),
                R("had to", "past obligation (*must* has no past)", "*We had to queue for an hour.*"),
                R("mustn't", "prohibition — don't do it", "*You mustn't tell anyone.*"),
                R("needn't / don't have to", "no obligation — it's optional", "*You needn't bring anything.*")
            ),
            new Note("The classic trap: *You **mustn't** tell anyone* (forbidden) vs *You **needn't** tell anyone* (optional).")
        ),
        new LearnSection(
            "need: perfect forms",
            new Table(
                ["Form", "Meaning", "Example"],
                R("needn't have done", "did it — but it turned out unnecessary", "*You needn't have brought wine! We've got plenty.*"),
                R("didn't need to do", "it wasn't necessary (and probably didn't do it)", "*I didn't need to get up early, so I slept in.*")
            )
        ),
        new LearnSection(
            "Advice and criticism",
            new Bullets(
                "**should / ought to** — general advice: *You should apologise.*",
                "**had better** (+ base form) — stronger, a consequence is implied: *You'd better apologise or she won't forgive you.* Negative: *had better not*.",
                "**should have + V3** — criticism or regret about the past: *You should have told me earlier.*"
            )
        ),
        new LearnSection(
            "Ability and permission",
            new Bullets(
                "**can / could** — general present and past ability: *I could swim at five.*",
                "**was able to / managed to** — one specific success in the past: *We managed to escape the fire.* (Not *~~could escape~~*.)",
                "**could have done** — an unrealised past possibility: *You could have been killed!*",
                "Permission: *can* (neutral), *could* (more polite), *may* (formal)."
            )
        )
    );

    // ------------------------------------------------------------------ reported speech

    private static readonly LearnLibrary.Topic ReportedSpeech = new(
        "reported-speech", "Reported speech", "Backshift table, time and place changes, and reporting-verb patterns.", "Grammar",
        new LearnSection(
            "Backshift",
            new Table(
                ["Direct", "Reported"],
                R("present simple", "past simple"),
                R("present continuous", "past continuous"),
                R("present perfect / past simple", "past perfect"),
                R("will / can / may / must", "would / could / might / had to"),
                R("shall", "would (offers: *should*)"),
                R("past perfect, should have, might have, could have", "no change")
            )
        ),
        new LearnSection(
            "Time and place words",
            new Table(
                ["Direct", "Reported"],
                R("now", "then / at that moment"),
                R("today / tonight", "that day / that night"),
                R("yesterday", "the day before / the previous day"),
                R("tomorrow", "the next day / the following day"),
                R("last week", "the week before / the previous week"),
                R("next month", "the following month"),
                R("ago", "before / earlier"),
                R("here / this / these", "there / that / those"),
                R("come / bring", "go / take")
            ),
            new Note("No backshift when the situation is still true or the reporting verb is present tense: *She says she **is** tired. / He said he **lives** in Rome.* (still true)")
        ),
        new LearnSection(
            "Reporting verbs: patterns",
            new Table(
                ["Pattern", "Verbs", "Example"],
                R("verb + (that) clause", "say, tell sb, explain, admit, deny, suggest, insist, recommend, demand", "*She suggested **(that) we leave** early.* (also *suggested + -ing*)"),
                R("verb + -ing", "suggest, admit, deny, recommend, regret, apologise for", "*He denied **stealing** it.*"),
                R("verb + to-infinitive", "offer, promise, refuse, threaten, agree, claim, decide", "*They offered **to help**.*"),
                R("verb + object + to-infinitive", "tell, advise, warn, remind, persuade, encourage, order, invite", "*I advised her **to wait**.*"),
                R("verb + object + preposition + -ing", "accuse sb **of**, congratulate sb **on**, thank sb **for**, blame sb **for**, suspect sb **of**, charge sb **with**, praise sb **for**", "*They accused him **of lying**.*"),
                R("explain / describe + sth + to sb", "never *~~explain sb sth~~*", "*She explained the rule **to me**.*")
            )
        )
    );

    // ------------------------------------------------------------------ quantifiers

    private static readonly LearnLibrary.Topic Quantifiers = new(
        "quantifiers", "Quantifiers", "much or many, few or little, each or every, all or whole — and the traps between.", "Grammar",
        new LearnSection(
            "Countable vs uncountable",
            new Table(
                ["Quantity", "Countable", "Uncountable"],
                R("large amount", "many, a (large) number of, several", "much, a (great) deal of, a large amount of"),
                R("'some' — positive", "a few", "a little"),
                R("'hardly any' — negative", "(very) few", "(very) little"),
                R("comparative", "fewer", "less"),
                R("question", "how many…?", "how much…?")
            ),
            new Note("*less* is creeping into countable use (*10 items or less*), but exams still want *fewer* + plural countable: *fewer cars, less traffic*.")
        ),
        new LearnSection(
            "a few vs few, a little vs little",
            new Para("**a few / a little** = some — a positive slant: *I have a few friends here* (enough to talk to). **few / little** = hardly any — negative: *Few students passed* (not many did). *Only a few* shares the negative force of *few*.")
        ),
        new LearnSection(
            "each vs every",
            new Bullets(
                "**each** — two or more, seen one by one: *Each twin has a key; each of the answers is different.*",
                "**every** — three or more, seen as a group: *Every seat was taken. Every time I call, she's out.*",
                "*almost / nearly + every* (not *~~almost each~~*); *every* + singular verb + singular noun."
            )
        ),
        new LearnSection(
            "all vs whole",
            new Bullets(
                "**all** + the / my + noun: *all the students, all my life*.",
                "**the whole** + noun: *the whole class, the whole trip*.",
                "*all day = the whole day*; with place names use *the whole of* or *all of*: *the whole of Madrid*.",
                "With plurals *whole* is rare: say *all the students*, not *~~the whole students~~*."
            )
        ),
        new LearnSection(
            "none, neither, either, both",
            new Bullets(
                "**none of** + the / us / them — verb can be singular (formal) or plural (informal): *None of them **was/were** late.*",
                "**neither … nor / either … or** — *Neither answer **is** correct. You can have either cake.*",
                "**neither of us/them** — *Neither of them **knows**.* Short answers: *Neither do I. / So do I.*",
                "**both (of)** — *We both agree; both of the windows are open.*",
                "**plenty of** works with both types: *plenty of time / plenty of chairs*."
            )
        )
    );

    // ------------------------------------------------------------------ relative clauses

    private static readonly LearnLibrary.Topic RelativeClauses = new(
        "relative-clauses", "Relative clauses", "Defining vs non-defining, every pronoun, and when you can drop it.", "Grammar",
        new LearnSection(
            "Defining vs non-defining",
            new Table(
                ["Feature", "Defining", "Non-defining"],
                R("Purpose", "identifies which one", "extra information about a known noun"),
                R("Punctuation", "no commas", "commas around the clause"),
                R("*that*", "possible", "impossible — use *which* or *who*"),
                R("Omitting the pronoun", "object pronouns only", "impossible"),
                R("Example", "*The woman **who lives** next door is a vet.*", "*My boss, **who studied** in Rome, speaks Italian.*")
            )
        ),
        new LearnSection(
            "The pronouns",
            new Table(
                ["Pronoun", "Refers to", "Example"],
                R("who", "people, as subject", "*the man **who** called you*"),
                R("whom", "people, as object — formal, or after a preposition", "*the client **whom** we invited; the partner with **whom** I work*"),
                R("which", "things", "*the book **which** won the prize*"),
                R("that", "people or things — defining clauses only", "*the keys **that** are on the table*"),
                R("whose", "possession", "*the author **whose** book I reviewed*"),
                R("where", "places", "*the café **where** we first met*"),
                R("when", "times", "*the summer **when** everything changed*"),
                R("why", "reasons — after *the reason*", "*the reason **why** she resigned*")
            )
        ),
        new LearnSection(
            "Omitting the pronoun",
            new Para("Only a **defining** clause with an **object** pronoun can lose it: *The film **(that)** we saw…*, *The man **(who)** I met…*. Subject pronouns and all non-defining clauses must keep their pronoun: *The film **that won** the prize…* (no omission).")
        ),
        new LearnSection(
            "Prepositions in relative clauses",
            new Bullets(
                "Formal: preposition + whom/which: *the colleague **with whom** I share an office*.",
                "Informal: preposition moves to the end, and the pronoun can go: *the colleague **(who/that) I share an office with**.*",
                "Never put a preposition directly before *that*: *~~with that I work~~*."
            )
        ),
        new LearnSection(
            "which for a whole clause; quantifier phrases",
            new Bullets(
                "*which* can refer to a whole sentence: *He arrived an hour late, **which** annoyed everyone.*",
                "quantifier + of whom / of which: *three cousins, **two of whom** live abroad; a list of tasks, **all of which** are overdue.*"
            )
        )
    );

    // ------------------------------------------------------------------ inversion

    private static readonly LearnLibrary.Topic Inversion = new(
        "inversion", "Inversion", "Negative adverbials, conditional inversion, and so/such fronting for Part 4.", "Grammar",
        new LearnSection(
            "How it works",
            new Para("Front the negative or limiting adverbial, then use **question word order**. With simple tenses that means *do/does/did*; with *be*, *have* and modals, invert directly: *Rarely **does he** complain. Never **have I** seen such a mess. Never **was** there any doubt.*")
        ),
        new LearnSection(
            "Negative adverbials",
            new Table(
                ["Trigger", "Example"],
                R("Never (before)", "**Never have I** seen such a mess."),
                R("Rarely / Seldom", "**Rarely did he** complain about the hours."),
                R("Little", "**Little did she** know what was waiting."),
                R("Nowhere", "**Nowhere else can you** find this species."),
                R("Not only … (but … also)", "**Not only did she win,** but she also broke the record."),
                R("No sooner … than", "**No sooner had we left than** it started to rain."),
                R("Hardly / Scarcely … when", "**Hardly had I sat down when** the phone rang."),
                R("Under no circumstances / On no account", "**Under no circumstances should you** open that door."),
                R("At no time", "**At no time did** the crew panic.")
            )
        ),
        new LearnSection(
            "Only, Not until, Not since",
            new Table(
                ["Trigger", "Example"],
                R("Only then / Only later", "**Only then did I** realise my mistake."),
                R("Only when / by / after + …", "**Only when she left did** I notice the letter."),
                R("Not until", "**Not until the next morning did** we hear the news."),
                R("Not since", "**Not since 2010 have** prices risen so fast.")
            )
        ),
        new LearnSection(
            "Conditional inversion",
            new Table(
                ["Plain", "Inverted"],
                R("*If you should need help…*", "**Should you need help,** call me."),
                R("*If I were in your position…*", "**Were I** in your position, I would refuse."),
                R("*If it were not for…*", "**Were it not for** your support, I'd have quit."),
                R("*If I had known…*", "**Had I known,** I would have called."),
                R("*If it had not been for…*", "**Had it not been for** the alarm, we'd have overslept.")
            )
        ),
        new LearnSection(
            "So and Such fronted",
            new Bullets(
                "**So + adjective**: *So beautiful was the view that we stayed for hours.*",
                "**Such + (a/an) + noun**: *Such was the demand that tickets sold out in minutes.*",
                "Echo replies follow the same rule: *So do I. / Neither do I. / So was mine.*"
            ),
            new DoDont(
                ["*Never have I seen such chaos.*", "*No sooner had we sat down than it began.*", "*Only later did she confess.*"],
                ["*~~Never I have seen such chaos.~~*", "*~~No sooner we had sat down…~~*", "*~~Only later she confessed.~~*"])
        )
    );

    /// <summary>All topics in canonical order. Declared after the topics it lists so
    /// static initialisation sees non-null values.</summary>
    public static readonly LearnLibrary.Topic[] All =
    [
        Articles, Tenses, Conditionals, VerbPatterns, Modals,
        ReportedSpeech, Quantifiers, RelativeClauses, Inversion,
    ];
}
