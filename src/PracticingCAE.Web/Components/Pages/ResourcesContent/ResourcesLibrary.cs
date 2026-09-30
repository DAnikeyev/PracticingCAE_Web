using static PracticingCAE.Web.Components.Pages.ResourcesContent.ResBlock;
using static PracticingCAE.Web.Components.Pages.ResourcesContent.ResText;

namespace PracticingCAE.Web.Components.Pages.ResourcesContent;

/// <summary>Registry of resource-guide sections rendered at /resources/{slug}.</summary>
public static class ResourcesLibrary
{
    /// <summary>One page of the guide: a slug, a card blurb, and ordered subsections.</summary>
    public sealed record Section(string Slug, string Title, string Blurb, params ResSection[] Content);

    public static readonly IReadOnlyList<Section> Sections =
    [
        // ---------------------------------------------------------------- 1. overview
        new Section(
            "overview", "How to use this guide",
            "Ten pages of hand-picked books, sites, apps and AI tools - and how to combine them into a working week.",
            new ResSection(
                "The one-page system",
                new Para(
                    "No single resource prepares you for C1 Advanced. The exam rewards four separate skills plus a " +
                    "working vocabulary of 8,000-10,000 words, so the job is to run a small system: one input stream, " +
                    "one practice stream, one feedback loop, one memory loop. Everything in this guide slots into one of those four."),
                new Table(
                    ["Loop", "What it does", "Best tools (links inside each page)"],
                    R("Input", "Builds real B2-C1 comprehension", "[Reading](/resources/reading) and [Listening](/resources/listening) picks"),
                    R("Practice", "Trains the exam formats themselves", "[Tests](/resources/tests) with answer keys and scores"),
                    R("Feedback", "Tells you what you got wrong and why", "[Write & Improve and AI checkers](/resources/writing), [AI voice tutors](/resources/speaking-ai)"),
                    R("Memory", "Stops vocabulary from leaking away", "[Anki and collocation tools](/resources/vocabulary)")),
                new Note(
                    "Rule of thumb: at least 60% of your time on input and memory, 40% on exam-format practice. " +
                    "Learners who only do practice tests plateau at B2+; learners who only read novels arrive at the exam untrained.")),
            new ResSection(
                "Balancing the four papers",
                new Para(
                    "Reading and Use of English, Writing, Listening and Speaking are scored separately and then averaged. " +
                    "Most self-studiers over-train Reading and under-train Speaking and Writing - the two papers where " +
                    "you produce language. Correct the balance deliberately."),
                new Table(
                    ["Paper", "Weekly minimum (approx)", "Feed it with"],
                    R("Reading and Use of English", "2 timed part-sets + error review", "[Practice tests](/resources/tests), [cheat sheets](/learn) for every part"),
                    R("Writing", "2 full texts, checked", "[Write & Improve](https://writeandimprove.com/) + [AI with the Cambridge scales](/resources/writing)"),
                    R("Listening", "4-5 sessions, at least one transcript-based", "[Podcasts with transcripts](/resources/listening), [practice tests](/resources/tests)"),
                    R("Speaking", "3-4 short sessions alone or with AI", "[Real-time voice AI](/resources/speaking-ai) + a human tutor when possible")),
                new Para(
                    "Not sure what each paper contains? The [exam overview](/guide/overview) and the part-by-part " +
                    "[guide](/guide/part-1) cover the format, timing and traps.")),
            new ResSection(
                "If you only pick five",
                new Table(
                    ["Pick", "Resource", "Why this one"],
                    R("1", "[engexam.info CAE tests](https://engexam.info/cae-reading-and-use-of-english-practice-tests/) + this site's [practice](/)", "22 Reading/Use of English and 30 Listening tests with keys, explanations and an estimated Cambridge score - free"),
                    R("2", "[Write & Improve](https://writeandimprove.com/)", "Cambridge's own free automatic feedback on writing - instant, honest, levelled"),
                    R("3", "[ChatGPT or Gemini voice mode](/resources/speaking-ai)", "Unlimited-ish speaking partner for Part 3/4-style discussion; free tiers are enough"),
                    R("4", "[BBC 6 Minute English](https://www.bbc.co.uk/learningenglish/features/6-minute-english) + [Luke's English Podcast](https://teacherluke.co.uk/)", "Daily listening at the right level, transcripts included"),
                    R("5", "[Anki](https://apps.ankiweb.net) + *English Collocations in Use Advanced*", "Vocabulary that actually survives until exam day")),
                new Para(
                    "With those five plus the [grammar and vocabulary cheat sheets](/learn) on this site, a disciplined " +
                    "learner can move from solid B2 to a pass-grade C1 in roughly 4-8 months at 60-90 minutes a day. " +
                    "Everything else in this guide is an upgrade, not a requirement."))),

        // ---------------------------------------------------------------- 2. workbooks
        new Section(
            "workbooks", "Coursebooks and workbooks",
            "The paper library: courses, trainers, grammar and vocabulary references worth owning at B2-C1.",
            new ResSection(
                "Courses and practice-test books",
                new Para(
                    "Courses give you structure; trainers give you guided exam practice. One of each is enough - " +
                    "you do not need two courses. Always buy editions marked **with answers** (and *with audio* where relevant), " +
                    "or you cannot self-check. Prices: approx GBP 25-45 per book new; older editions are fine and much cheaper."),
                new Table(
                    ["Book", "What it gives you", "Best for", "Answer key?", "Approx level"],
                    R("[Complete Advanced](https://www.cambridge.org/elt) (Coursebook + Workbook, Cambridge)", "Full B2-C1 course: 25 units covering every paper, workbook adds extra practice", "Learners who want a complete course with a path", "Yes (with-answers editions)", "B2-C1"),
                    R("[Objective Advanced](https://www.cambridge.org/elt) (Cambridge)", "Lighter course: short units, exam folders, self-study friendly", "Self-studiers who find Complete too heavy", "Yes (with-answers editions)", "B2-C1"),
                    R("[Ready for Advanced](https://www.macmillanenglish.com) (Coursebook + Workbook, Macmillan)", "Course with a strong exam-technique focus and clear grammar sections", "Learners close to C1 who need polishing, not teaching", "Yes (with-answers editions)", "B2-C1"),
                    R("[Advanced Trainer](https://www.cambridge.org/elt) (Cambridge)", "6 practice tests with before/after advice, answers and explanations", "Guided test practice between mocks", "Yes", "C1"),
                    R("[Exam Booster for Advanced](https://www.cambridge.org/elt) (Cambridge)", "60+ bite-sized tasks (15-30 min each) with exam tips", "Short daily drills when a full test is too much", "Yes", "B2-C1")),
                new Note(
                    "Older editions (pre-2018) are acceptable for language practice, but check the format of the Reading " +
                    "and Use of English parts against the [current sample papers](https://www.cambridgeenglish.org/exams-and-tests/advanced/preparation/) " +
                    "so you are not drilling a retired pattern.")),
            new ResSection(
                "Grammar and vocabulary references",
                new Table(
                    ["Book", "What it gives you", "Best for", "Answer key?", "Approx level"],
                    R("[English Grammar in Use](https://www.cambridge.org/elt) (Murphy)", "The classic reference: one unit per grammar point, exercises on the facing page", "Patching B2 gaps (articles, conditionals, modals)", "Yes (with-answers edition)", "B1-B2 foundation"),
                    R("[Advanced Grammar in Use](https://www.cambridge.org/elt) (Hewings)", "The C1 counterpart: inversion, cleft sentences, nominalisation, referencing", "The grammar the exam actually samples at C1", "Yes (with-answers edition)", "C1"),
                    R("[English Vocabulary in Use Advanced](https://www.cambridge.org/elt)", "2,000+ words and phrases in 100 two-page units, indexed", "Systematic vocabulary building", "Yes", "C1"),
                    R("[English Collocations in Use Advanced](https://www.cambridge.org/elt)", "Natural word partnerships (heavy reliance, pose a threat) in context", "The fastest way to sound C1 in Writing and Speaking", "Yes", "B2-C1"),
                    R("[English Phrasal Verbs in Use Advanced](https://www.cambridge.org/elt)", "Advanced phrasal verbs by topic and particle", "Part 1/4 and the Speaking test", "Yes", "B2-C1"),
                    R("[Destination C1-C2](https://www.macmillanenglish.com) (Mann, Taylore-Knowles)", "Dense grammar + vocabulary course with hundreds of exercises", "Learners who want pure practice volume over explanation", "Yes (with-key edition)", "C1-C2")),
                new Para(
                    "How to use them: a reference is for looking things up after an error, not for reading cover to cover. " +
                    "When a [cheat sheet](/learn) or a test marks you wrong on, say, inverted conditionals, read that unit, " +
                    "do the exercises, then write three sentences of your own. This site's [word-formation](/learn/word-formation) and " +
                    "[key word transformation](/learn/kwt-patterns) sheets map closely onto what these books cover."))),

        // ---------------------------------------------------------------- 3. tests
        new Section(
            "tests", "Practice tests with checking",
            "Official sample papers and free test sites that actually mark your answers - plus how to self-mark writing.",
            new ResSection(
                "Start official: Cambridge sample papers",
                new Bullets(
                    "[C1 Advanced preparation page](https://www.cambridgeenglish.org/exams-and-tests/advanced/preparation/) - free sample papers for every part as PDFs **with answer keys and audio**, plus a free online sample test and examiner-commented speaking videos. This is the ground truth for format and difficulty.",
                    "Do at least one full official sample under exam timing before anything else; it calibrates everything else you study. The [timing guide](/guide/timing) has the per-part budgets.",
                    "Cambridge also sells extra official practice tests online (approx GBP 30-40) if you exhaust the free material.")),
            new ResSection(
                "Free test sites with auto-checking",
                new Table(
                    ["Site", "What you get", "Checking", "Cost"],
                    R("[engexam.info](https://engexam.info/cae-reading-and-use-of-english-practice-tests/)", "22 CAE Reading/Use of English tests + 30 listening tests with tapescripts", "Instant scoring, answer keys, explanations, estimated Cambridge-scale grade", "Free"),
                    R("[Flo-Joe](https://www.flo-joe.co.uk/)", "CAE practice tests, Use of English exercises, daily vocabulary", "Marked quizzes with answers", "Free (membership extras)"),
                    R("[Exam English](https://www.examenglish.com/CEFR/C1.htm)", "CAE-format reading, listening, grammar and writing tasks", "Instant-scoring interactive tests", "Free"),
                    R("[ESL-lounge](https://www.esl-lounge.com/student/advanced.php)", "C1 exam-preparation quizzes across all Use of English parts", "Answers on site; premium adds interactivity", "Free samples"),
                    R("[Test-English](https://test-english.com/grammar-points/c1/)", "C1 grammar/listening lessons with exercises, level tests and exam section", "Auto-checked, with explanations", "Free"),
                    R("[engxam](https://engxam.com/handbook/exams/c1-advanced-cae/)", "CAE handbook by part + online practice tests for Use of English", "Auto-checked platform", "Free + paid tiers")),
                new Note(
                    "Quality varies outside the official material: some third-party tests are harder or easier than the real " +
                    "exam. Treat engexam's estimated grades as a rough signal, and always re-check surprising answers " +
                    "against the explanations rather than trusting the score blindly.")),
            new ResSection(
                "Self-marking your writing",
                new Para(
                    "No free site reliably marks CAE writing except [Write & Improve](/resources/writing). For everything else, " +
                    "mark against Cambridge's own published scales: **Content, Communicative Achievement, Organisation, Language**, " +
                    "each 0-5. The scales and annotated sample answers are in the free [C1 Advanced handbook](https://www.cambridgeenglish.org/exams-and-tests/advanced/preparation/)."),
                new Steps(
                    "Write the task in 40 minutes (Part 1: 220-250 words; Part 2: 220-260). Count words.",
                    "Mark Content first: is every prompted point covered with some development? Half-developed points cap you at 3.",
                    "Mark Communicative Achievement: correct text type and register throughout? [This register cheat sheet](/learn/linking-words) lists formal vs neutral markers.",
                    "Mark Organisation: one clear paragraph per idea, linking words used but not decorated.",
                    "Mark Language: circle every error you can find yourself; range (complex structures, less common vocabulary) matters as much as accuracy.",
                    "Rewrite the weakest paragraph. The rewrite is where the learning happens.")),
            new ResSection(
                "Where this site fits",
                new Para(
                    "The [practice](/) section drills every Reading and Use of English part with instant checking, and the " +
                    "[prepare-with-this-site guide](/guide/preparation) turns it into a plan. Use third-party tests for volume; " +
                    "use official samples for calibration."))),

        // ---------------------------------------------------------------- 4. reading
        new Section(
            "reading", "Reading",
            "Graded readers, authentic sources pitched right, and free read-and-quiz sites - with a B2-to-C1 progression.",
            new ResSection(
                "Graded readers (bridge level)",
                new Table(
                    ["Series", "Levels", "Why use it", "Cost"],
                    R("[Penguin Readers](https://www.penguinreaders.co.uk/)", "8 levels; top level approx C1", "Contemporary titles and classics retold at controlled vocabulary; free audio and teacher's notes on many titles", "approx GBP 8-12 per reader"),
                    R("[Oxford Bookworms Library](https://elt.oup.com/cat/subjects/graded_reading/)", "Stages 1-6; Stage 6 approx C1", "Huge back catalogue of adaptations; reliable level control", "approx GBP 8-12 per reader")),
                new Para(
                    "At B2 start at Level 5-6 / Stage 5; at C1 you should be leaving graded readers behind within 2-3 books. " +
                    "Their job is to make long-form reading in English feel normal, not to teach the exam.")),
            new ResSection(
                "Authentic sources at the right difficulty",
                new Table(
                    ["Source", "Difficulty", "Use it for", "Cost"],
                    R("[The Guardian](https://www.theguardian.com)", "B2-C1", "Long reads, opinion and features - closest in register to exam texts", "Free (donation-funded)"),
                    R("[BBC News](https://www.bbc.com/news)", "B2+", "Short daily news; also the source style of many exam texts", "Free"),
                    R("[The Economist](https://www.economist.com)", "C1+", "Dense argumentation and sophisticated lexis - a genuine C1-C2 stretch", "Paywalled (metered free articles)"),
                    R("[Aeon](https://aeon.co)", "C1+", "Long essays on science, philosophy, culture - ideal for Part 7/8 stamina", "Free"),
                    R("[Ars Technica](https://arstechnica.com)", "B2-C1", "Science and technology writing if that is your interest area", "Free")),
                new Note(
                    "Exam texts are written to inform a general educated reader - exactly Guardian-feature territory. " +
                    "If you can read two Guardian long reads a week with 90% understanding, Part 8 length stops intimidating you.")),
            new ResSection(
                "Reading with questions (free)",
                new Table(
                    ["Site", "What you get", "Level"],
                    R("[Breaking News English](https://breakingnewsenglish.com/)", "News lessons in 7 levels: multi-speed audio, comprehension quiz, vocabulary tasks per story", "Levels 4-7 approx B1-C1"),
                    R("[Lingua.com English reading](https://lingua.com/english/reading/)", "42 free texts with multiple-choice comprehension quizzes, A1-C2, PDF downloads", "B2-C1 sections usable"),
                    R("[ESL-lounge reading](https://www.esl-lounge.com/student/advanced.php)", "Advanced-level reading passages with questions in the exam-preparation section", "C1"),
                    R("[ReadWorks](https://www.readworks.org)", "Thousands of K-12 passages with question sets; nonfiction is excellent intensive practice", "B2-C1 (native-child texts)"),
                    R("[News in Levels](https://www.newsinlevels.com/)", "Same story at 3 vocabulary-controlled levels", "Caps around **B1** - good only as a warm-up at this level")),
                new Note(
                    "News in Levels is marked here so you do not waste time on it: its Level 3 is roughly B1. " +
                    "If it feels comfortable, you are reading below exam level.")),
            new ResSection(
                "B2 to C1: the progression",
                new Bullets(
                    "**Extensive reading (70%):** easy-enough material, read fast for meaning, no dictionary. Builds speed and the 8,000-10,000 word vocabulary the exam assumes.",
                    "**Intensive reading (30%):** one or two pages of harder text, dissected: unknown phrases into [Anki](/resources/vocabulary), paragraph function labelled (contrast? concession? evidence?). This is what Part 7 gapped-text actually tests.",
                    "Track one number: words read per minute at full comprehension. Graded readers approx 150; Guardian long read approx 200-220; that is exam pace.",
                    "Once a week, summarise what you read in 5 sentences and check it with the [writing workflow](/resources/writing) - reading and writing feed each other."))),

        // ---------------------------------------------------------------- 5. listening
        new Section(
            "listening", "Listening",
            "Podcasts and audio with transcripts for B2-C1, news at real speed, and a dictation routine that works.",
            new ResSection(
                "Podcasts with transcripts",
                new Table(
                    ["Podcast", "What it is", "Transcript?", "Level", "Cost"],
                    R("[6 Minute English](https://www.bbc.co.uk/learningenglish/features/6-minute-english) (BBC)", "6-minute episodes, one topic, six vocabulary items", "Yes, on the page", "B2-C1", "Free"),
                    R("[The English We Speak](https://www.bbc.co.uk/learningenglish/english/features/the-english-we-speak) (BBC)", "3-minute idioms and colloquialisms", "Yes, on the page", "B2+", "Free"),
                    R("[Luke's English Podcast](https://teacherluke.co.uk/)", "1,000+ episodes of British English: stories, topics, language analysis", "Many episodes, some premium", "B2-C1", "Free (premium transcripts)"),
                    R("[All Ears English](https://www.allearsenglish.com/)", "American English, 15-min episodes on vocabulary and strategy", "Via membership", "B2-C1", "Free"),
                    R("[Plain English](https://plainenglish.com/)", "News and culture at a measured pace, key words explained", "Yes - [all transcripts free](https://plainenglish.com/all-transcripts/)", "B1-B2 bridge", "Free")),
                new Para(
                    "The transcript is the tool: first listen without it, then listen reading it, mark what you did not catch, " +
                    "and finally shadow 30 seconds aloud. One episode processed this way beats ten passive ones.")),
            new ResSection(
                "News audio at real speed",
                new Table(
                    ["Source", "What it is", "Transcript?", "Level"],
                    R("[Global News Podcast](https://www.bbc.co.uk/programmes/p02nq0gn) (BBC World Service)", "30 min, twice daily on weekdays; exam-Part-4-adjacent accents and speed", "No", "C1"),
                    R("[The Intelligence](https://www.economist.com/podcasts/) (The Economist)", "Daily ~25-min analysis show; dense, well-articulated argument", "No", "C1+"),
                    R("[NPR](https://www.npr.org)", "US news and talk; most program pages publish transcripts", "Many programs, yes", "C1"),
                    R("[TED Talks](https://www.ted.com)", "Any talk, any topic, with interactive transcripts and subtitles", "Yes, full", "B2-C1"))),
            new ResSection(
                "Dictation and pronunciation drills",
                new Bullets(
                    "**Self-dictation with TED:** pick 30-60 seconds of a [TED talk](https://www.ted.com), transcribe it by ear, then compare with the official transcript. Every missed word is a listening gap, not a spelling problem - usually weak spots in connected speech (linking, weak forms).",
                    "**[YouGlish](https://youglish.com):** type any word or phrase and hear it spoken by real speakers across accents in YouTube clips. Use it whenever a word's pronunciation surprises you.",
                    "**YouTube transcripts:** on any video, open the description menu and choose *Show transcript* to follow the auto-captions - imperfect but usable for shadowing.",
                    "Dictation builds Part 3/4 note-taking; shadowing builds the pronunciation the [Speaking test](/resources/speaking-ai) scores.")),
            new ResSection(
                "A progression that works",
                new Bullets(
                    "**Weeks 1-4:** 6 Minute English daily with transcript; Luke's English Podcast in the background.",
                    "**Weeks 5-8:** drop the transcript for first listens; add one Global News Podcast episode per day.",
                    "**Week 9+:** real-speed news only (Global News, The Intelligence), TED self-dictation 3x per week.",
                    "Test-format listening still comes from [practice tests](/resources/tests) - podcasts build the ear, tests build the exam reflex."))),

        // ---------------------------------------------------------------- 6. writing
        new Section(
            "writing", "Writing with feedback",
            "How to get real feedback on CAE writing for free: Write & Improve, AI with the official scales, and model answers.",
            new ResSection(
                "Write & Improve (Cambridge, free)",
                new Para(
                    "[Write & Improve](https://writeandimprove.com/) is Cambridge University Press & Assessment's free automatic " +
                    "writing-feedback tool: you submit a text, it returns CEFR-levelled feedback in seconds, you revise and resubmit. " +
                    "It offers hundreds of tasks by CEFR level plus a B2 First Test Zone. *Status checked September 2026: still live and free.* " +
                    "It is the only zero-cost tool built on Cambridge's own assessment research."),
                new Bullets(
                    "Use it for volume: two texts a week, revise each one at least twice - the resubmission score movement is the feedback.",
                    "It is tuned to general CEFR and B2 First tasks, so for C1 Advanced formats, paste the official Part 1/Part 2 prompts (from the [sample papers](https://www.cambridgeenglish.org/exams-and-tests/advanced/preparation/)) and treat the level estimate as a signal, not a grade.",
                    "It will not check exam-specifics like word count or text-type conventions - do that with the checklist below.")),
            new ResSection(
                "AI chatbots with the official scales",
                new Para(
                    "Any strong chatbot (ChatGPT, Gemini, Claude) marks CAE writing surprisingly well **if you give it the rubric**. " +
                    "The official assessment scales - Content, Communicative Achievement, Organisation, Language, each 0-5 - are in the free " +
                    "[C1 Advanced handbook](https://www.cambridgeenglish.org/exams-and-tests/advanced/preparation/). Paste them in, then paste your text."),
                new Steps(
                    "Paste the Cambridge writing scales and say: *You are a Cambridge C1 Advanced examiner. Mark my text against these scales, 0-5 on each, with one sentence of justification per scale.*",
                    "Paste your task prompt and your answer. Add: *Then list every grammar or word-choice error with a corrected version, and tell me which errors are typical of B2 vs C1 writers.*",
                    "Ask for the ceiling: *What would need to change for Language to reach 5?* - then rewrite only that.",
                    "Cross-check with [Write & Improve](https://writeandimprove.com/). Two independent opinions stop you trusting one bot's leniency.",
                    "Keep every text in one document; every second week, re-read the oldest - recurring errors become your personal grammar syllabus ([cheat sheets](/learn) for each).")),
            new ResSection(
                "Model answers",
                new Table(
                    ["Source", "What it gives you", "Cost"],
                    R("[C1 Advanced handbook + sample papers](https://www.cambridgeenglish.org/exams-and-tests/advanced/preparation/)", "Real candidate answers with examiner comments - the only models that show the full grade band", "Free"),
                    R("[KSE Academy](https://kseacademy.com/)", "CAE writing guides with worked sample answers for every Part 2 text type, plus useful-phrase lists", "Free articles + paid guides"),
                    R("[engexam.info writing tasks](https://engexam.info/ielts-cae-practice-tests/)", "CAE-format writing tasks to attempt against the official criteria", "Free")),
                new Note(
                    "Read models after writing your own attempt, never before - otherwise you collect phrases but never practise the hard part, " +
                    "which is generating the structure under time pressure.")),
            new ResSection(
                "Per-text-type checklist",
                new Table(
                    ["Text type", "Register", "Structure that scores"],
                    R("Essay (Part 1)", "Formal, impersonal", "Intro rephrasing the question; one body paragraph per prompted point + your own point; conclusion with a stance"),
                    R("Review", "Semi-formal, engaging", "What + evaluation woven in, not plot summary; clear recommendation at the end"),
                    R("Report", "Formal, factual", "Headings; purpose stated up front; findings grouped; recommendation section"),
                    R("Proposal", "Formal, persuasive", "Situation, aims, benefits, practicalities - sell the idea to the reader"),
                    R("Email / letter", "Formal or semi-formal per prompt", "Consistent register from salutation to sign-off; every bullet of the prompt covered in order"),
                    R("All types", "-", "220-260 words (Part 1: 220-250); paragraphs of 3-5 sentences; [linking words](/learn/linking-words) doing real work, not decoration")))),

        // ---------------------------------------------------------------- 7. speaking-ai
        new Section(
            "speaking-ai", "AI speaking partners",
            "Real-time voice AI you can actually talk to - what each tool does, what it costs, and how to run CAE Part 3/4 practice with it.",
            new ResSection(
                "Real-time voice tools compared",
                new Para(
                    "Everything below does **real-time audio** - you talk, it talks back live, over your speech - not dictation " +
                    "into a text box. Pricing changes often; figures are approximations as of September 2026."),
                new Table(
                    ["Tool", "What it is", "Real-time voice?", "Feedback on your English?", "Free / paid (approx)", "Platforms"],
                    R("[ChatGPT](https://chatgpt.com) (OpenAI)", "General assistant with full voice mode", "Yes", "On request - corrections and band-style scoring if you prompt it (see below); no native scoring", "Free tier approx 15 min/day voice; Plus approx $20/mo", "iOS, Android, web, desktop"),
                    R("[Gemini Live](https://gemini.google.com)", "Google's live voice assistant", "Yes - interruptible, can share camera/screen (useful for Part 2 pictures)", "On request, same prompting approach", "Free core; Google AI Pro approx $20/mo for higher limits", "iOS, Android, web"),
                    R("[Claude](https://claude.ai) voice mode", "Voice conversations in the Anthropic mobile app (beta)", "Yes - all plans incl. free, with usage limits", "General-purpose; correction on request", "Free with limits; Pro approx $20/mo", "iOS, Android (web voice rolling out)"),
                    R("[Speak](https://www.speak.com/)", "Speaking-first AI tutor built around conversation", "Yes - live roleplays", "Yes - real-time corrections, pronunciation, proficiency tracking", "No free tier; 7-day trial; approx $7-20/mo", "iOS, Android"),
                    R("[ELSA Speak](https://elsaspeak.com/)", "Pronunciation specialist, now with [ELSA AI](https://elsaspeak.com/en/ai) conversations", "Yes", "Yes - phoneme-level pronunciation scoring, its core strength", "Free tier limited; Premium approx $160/yr; free web [Speech Analyzer](https://speechanalyzer.elsaspeak.com/)", "iOS, Android, web"),
                    R("[TalkPal](https://talkpal.ai)", "GPT-based tutor: roleplays, debates, scenarios in voice or chat", "Yes", "Yes - corrections and phrase suggestions after turns", "Free limited daily use; Premium approx $5-10/mo billed annually", "iOS, Android, web"),
                    R("[Langua](https://languatalk.com/) (LanguaTalk)", "Conversation app with very natural voices and dialect choice", "Yes", "Yes - corrections, transcripts, post-session reports, saved vocabulary", "Free trial; approx $160-199/yr", "Web, iOS, Android"),
                    R("[Praktika](https://praktika.ai)", "AI avatar tutors in video-call style", "Yes", "Yes - feedback and progress reports", "Free trial; approx $120/yr (~$8-10/mo)", "iOS, Android"),
                    R("[Univerbal](https://www.univerbal.app/)", "Exam-style speaking practice with scoring", "Yes", "Yes - structured scoring, closest off-the-shelf fit to exam tasks", "Free approx 10 min/day; Pass approx $15-20/mo or $120/yr", "iOS, Android, web"),
                    R("[Loora](https://www.loora.ai)", "English-only conversation coach", "Yes", "Yes - live corrections on grammar, pronunciation, fluency", "Short free trial; approx $10/mo annual, $20 monthly", "iOS, Android, web"),
                    R("[Duolingo Max](https://www.duolingo.com/help/what-is-duolingo-max)", "Adds AI features incl. Video Call with the character Lily", "Yes - on-demand video roleplay calls", "Light feedback; more conversation than correction", "Approx $30/mo or $168/yr", "iOS, Android")),
                new Note(
                    "Honest ranking for CAE prep: for sheer conversation volume, ChatGPT or Gemini free voice modes are the best value. " +
                    "For pronunciation diagnosis, ELSA is ahead. For exam-shaped tasks with scoring, Univerbal. " +
                    "The general assistants win on flexibility because you can feed them the exact Cambridge task format.")),
            new ResSection(
                "Humans still win the real thing",
                new Para(
                    "AI never runs out of patience and never judges - which is exactly why it is not the exam. A human partner " +
                    "interrupts, misunderstands, and forces repair strategies (Part 3 and Part 4 reward managing interaction, not just talking)."),
                new Table(
                    ["Platform", "What it is", "Approx cost"],
                    R("[italki](https://www.italki.com)", "Marketplace of community tutors and professional teachers; filter for Cambridge-exam experience", "from ~$5/h; typical $10-25/h"),
                    R("[Preply](https://preply.com)", "Similar marketplace, more structured/test-prep oriented", "typical $15-25/h"),
                    R("[Cambly](https://www.cambly.com)", "On-demand native speakers, no booking needed; less exam-specialised", "subscription, ~$12-15/h effective")),
                new Para(
                    "A good split: AI daily for volume and repetition drills; a human tutor weekly for mock speaking tests and pushback. " +
                    "Even one paid mock per month with an exam-experienced tutor is worth ten AI sessions.")),
            new ResSection(
                "Prompt guide: CAE speaking with a voice AI",
                new Para(
                    "The C1 Speaking test has four parts: an interview, a 1-minute picture comparison (Part 2), a collaborative " +
                    "discussion (Part 3) and a themed discussion (Part 4). A general assistant handles all of these once told what to do."),
                new Steps(
                    "**Set the role.** Say: *You are a Cambridge C1 Advanced examiner. Run Speaking Part 3 with me. Give me the task sheet (question + five prompts), then discuss it with me as my partner for 2 minutes, then ask me two Part 4 follow-up questions.*",
                    "**Keep it live and timed.** Add: *Do not type long replies - keep each turn under three sentences so I do most of the talking. Time-box the task to 4 minutes.*",
                    "**Demand correction bursts.** After the task: *List my five worst grammar errors, five word choices to upgrade, and two pronunciation issues - each with a corrected example.* Asking for a burst afterwards keeps the conversation flowing; asking mid-stream kills it.",
                    "**Ask for band-style feedback.** Finish with: *Rate me on the Cambridge speaking scales - grammar, vocabulary, discourse management, pronunciation, interactive communication - one sentence each with evidence from what I actually said.*",
                    "**Iterate.** Repeat the same task twice in a week before moving on; ask for a harder variant (*make the question more abstract*) once your self-rating is stable.",
                    "**Part 2 tip:** Gemini and ChatGPT accept images - send a photo pair and ask it to act as examiner for the 1-minute long turn, then model a strong answer for you to compare with."))),

        // ---------------------------------------------------------------- 8. vocabulary
        new Section(
            "vocabulary", "Vocabulary and memory",
            "Spaced repetition done right, word lists worth mining, and tools for checking how words really combine.",
            new ResSection(
                "Spaced repetition systems",
                new Table(
                    ["Tool", "What it is", "Cost"],
                    R("[Anki](https://apps.ankiweb.net)", "The spaced-repetition standard; search *C1 Advanced* or *CAE* in shared decks for a starting pack, then add your own cards", "Free on desktop and Android; iOS app $24.99 once"),
                    R("[Quizlet](https://quizlet.com)", "Easier to start; huge shared deck library; weaker long-term algorithm", "Free tier; Plus approx $36/yr")),
                new Note(
                    "Pre-made CAE decks exist but generic cards stick badly. The cards that work are the ones you make from " +
                    "your own errors: a phrase you met in a [Guardian long read](/resources/reading), a collocation an AI corrected " +
                    "in your writing, a linker you failed to produce in speaking.")),
            new ResSection(
                "Word lists worth mining",
                new Bullets(
                    "[Flo-Joe word bank](https://www.flo-joe.co.uk/) - themed CAE vocabulary sets and a word-of-the-day habit, exam-focused and free.",
                    "*[English Vocabulary in Use Advanced](/resources/workbooks)* - the systematic backbone: 100 units, index, answer key.",
                    "*[English Collocations in Use Advanced](/resources/workbooks)* - mine one unit per session; collocations are what separate B2 from C1 answers.",
                    "This site's [confusable words](/learn/confusable-words) and [word formation](/learn/word-formation) sheets - the exact failure patterns of Parts 3 and 4.")),
            new ResSection(
                "Checking how words combine",
                new Table(
                    ["Tool", "What it does", "Cost"],
                    R("[freecollocation.com](https://www.freecollocation.com/)", "Free online Oxford Collocation Dictionary - 150,000+ collocations for 9,000 headwords", "Free"),
                    R("[Oxford Learner's Dictionaries](https://www.oxfordlearnersdictionaries.com/definition/collocations/)", "Official OUP learner dictionary with collocations boxes on entries", "Free"),
                    R("[ozdic](https://ozdic.com)", "Alternative free collocation dictionary, quick to search", "Free"),
                    R("[Ludwig](https://ludwig.guru)", "Searches real published sentences - verify a phrase before you use it in writing", "Free limited; paid tiers"),
                    R("[YouGlish](https://youglish.com)", "Hear any word or phrase in real YouTube clips across accents", "Free")),
                new Para(
                    "A 15-minute daily loop that works: review due cards in Anki (10 min), add 5-10 new cards mined from your " +
                    "reading/writing errors (5 min), look up every new card's collocations before adding it - not after. " +
                    "For the exam's word-formation and transformation parts, work through the [prepositions](/learn/prepositions) and " +
                    "[phrasal verbs](/learn/phrasal-verbs) sheets as well; they are the highest-frequency lexis in Part 4."))),

        // ---------------------------------------------------------------- 9. videos
        new Section(
            "videos", "Video channels",
            "YouTube channels that teach exam-relevant English, plus TED for listening material with substance.",
            new ResSection(
                "Channels worth subscribing to",
                new Table(
                    ["Channel", "Focus", "Why keep it"],
                    R("[BBC Learning English](https://www.youtube.com/@bbclearningenglish)", "Daily short lessons: vocabulary, pronunciation, news review", "Directly aligned to the Cambridge exams; includes exam-specific playlists"),
                    R("[engVid](https://www.engvid.com/)", "1,800+ lessons from a dozen teachers, indexed by topic and level", "Long-form grammar explanations when a cheat sheet is not enough"),
                    R("[English with Lucy](https://www.youtube.com/@EnglishWithLucy)", "British pronunciation, vocabulary, fluency habits", "Clear phonetics work for the Speaking test"),
                    R("[Canguro English](https://www.youtube.com/@Canguroenglish)", "Grammar and learning theory from a Cambridge-exam teacher", "The back catalogue explains the *why* behind C1 grammar"),
                    R("[Write to Top](https://www.youtube.com/@writetotop)", "Academic and exam writing: structure, cohesion, sentence variety", "The best free complement to the [writing workflow](/resources/writing)"),
                    R("[Learn English with TV Series](https://www.youtube.com/@LearnEnglishWithTVSeries)", "Vocabulary and pronunciation from real show clips", "Bridges authentic fast speech - good Part 4 accent training")),
                new Note(
                    "Channel activity changes; the links go to each channel so you can see current uploads yourself. " +
                    "Treat YouTube as a supplement: one focused lesson beats an hour of recommended-video drift.")),
            new ResSection(
                "TED and TED-Ed",
                new Bullets(
                    "[TED](https://www.ted.com) - full talks with interactive transcripts: use for [listening drills](/resources/listening) and for writing content. C1 essays and Speaking Part 4 rewards opinions with examples; talks hand you both.",
                    "[TED-Ed](https://www.youtube.com/@TEDEd) - 5-minute animated explainers; dense but short, ideal for a daily transcript session.",
                    "Watch once for ideas, once with transcript, then steal five phrases into [Anki](/resources/vocabulary)."))),

        // ---------------------------------------------------------------- 10. immersion
        new Section(
            "immersion", "Immersion",
            "Films, subtitled-to-naked viewing, read-with-lookup tools, and a weekly routine that turns English into your default.",
            new ResSection(
                "Films and TV: the subtitles ladder",
                new Steps(
                    "**Start: English subtitles on.** Rewatch shows you already know so plot does not eat the bandwidth. British drama (the accent examiners use) and mockumentary dialogue are ideal.",
                    "**Middle: subtitles off for re-watching only.** First watch with subs for pleasure, immediate second viewing without. Guessing from context is the skill Part 4 rewards.",
                    "**Goal: no subs on first watch** for anything you would watch in your own language anyway. If comprehension drops below 80%, the content is too far above you - drop one difficulty level instead of switching subs back.",
                    "**Keep a capture rule:** max three new phrases per episode into [Anki](/resources/vocabulary). More becomes transcription, not viewing.")),
            new ResSection(
                "Reading with click-lookup",
                new Table(
                    ["Tool", "What it does", "Cost (approx)"],
                    R("[LingQ](https://www.lingq.com)", "Import any article or ebook; click words for instant translations, tracked as known/unknown with SRS review", "$13/mo monthly, $8-9/mo annual"),
                    R("[Readlang](https://readlang.com)", "Web reader and EPUB import with click-translation and export to Anki; cleaner and cheaper than LingQ", "$6/mo or $48/yr; Plus $15/mo adds AI voices")),
                new Para(
                    "At C1, either tool mainly buys you persistence: dictionary friction is why people quit long-form reading. " +
                    "If you already read comfortably, skip both and mine words manually - the [vocabulary page](/resources/vocabulary) " +
                    "loop is cheaper.")),
            new ResSection(
                "Environment changes",
                new Bullets(
                    "**Switch your phone and OS language to English.** A day-one change that costs nothing and silently drills tech vocabulary.",
                    "**Beware AI dubbing and auto-translate:** YouTube increasingly dubs videos into your UI language and Chrome offers to translate pages. Turn both off - they quietly remove exactly the input you are trying to get.",
                    "**Follow English-first feeds:** news apps (BBC, Guardian), podcasts, and one or two [channels](/resources/videos) instead of native-language equivalents.",
                    "**Think in English during dead time:** narrate your commute silently; the gaps you hit are tomorrow's Anki cards.")),
            new ResSection(
                "A weekly immersion routine",
                new Table(
                    ["Day", "30-minute block", "Skill fed"],
                    R("Mon", "Podcast + transcript processing ([6 Minute English](https://www.bbc.co.uk/learningenglish/features/6-minute-english) or Luke's)", "Listening"),
                    R("Tue", "TV episode, no subtitles, 3 phrases captured", "Listening, fluency"),
                    R("Wed", "Guardian long read with [Readlang/LingQ](https://readlang.com) or manual mining", "Reading"),
                    R("Thu", "TED talk: watch, then [self-dictate 60 seconds](/resources/listening)", "Listening, writing"),
                    R("Fri", "[AI voice debate](/resources/speaking-ai) on the week's reading topics", "Speaking"),
                    R("Sat", "Film with English subtitles + review all week's Anki cards", "All"),
                    R("Sun", "One [full writing task](/resources/writing) about anything you consumed this week", "Writing")),
                new Note(
                    "The Sunday writing task is the keystone: it forces the week's input to become output, which is where " +
                    "passive vocabulary turns into marks. Then get it checked via [Write & Improve](https://writeandimprove.com/) or the " +
                    "[AI rubric workflow](/resources/writing).")))];

    public static Section? Find(string slug) =>
        Sections.FirstOrDefault(s => s.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
}
