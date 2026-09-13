using static PracticingCAE.Web.Components.Pages.LearnContent.LearnBlock;
using static PracticingCAE.Web.Components.Pages.LearnContent.LearnText;

namespace PracticingCAE.Web.Components.Pages.LearnContent;

/// <summary>Vocabulary and usage cheat sheets, in canonical order.</summary>
public static class VocabularyTopics
{
    // ------------------------------------------------------------------ prepositions

    private static readonly LearnLibrary.Topic Prepositions = new(
        "prepositions", "Dependent prepositions", "Verb + preposition, adjective + preposition, noun + preposition — the high-frequency exam ones.", "Vocabulary and usage",
        new LearnSection(
            "Verb + preposition",
            new Table(
                ["Pattern", "Examples"],
                R("apologise **to sb for sth**", "*I apologised to her **for being late**.*"),
                R("apply **to** (company) **for** (job)", "*She applied **to** the council **for** a grant.*"),
                R("accuse sb **of** / suspect sb **of**", "*He was accused **of** theft.*"),
                R("blame sb **for** sth / blame sth **on** sb", "*They blamed the driver **for** the crash. / They blamed the crash **on** the driver.*"),
                R("congratulate sb **on**", "*I congratulated her **on** her promotion.*"),
                R("depend **on** / rely **on** / insist **on**", "*It depends **on** the weather. He insisted **on** paying.*"),
                R("object **to** / look forward **to** / be used **to**", "*I object **to** being kept waiting.*"),
                R("succeed **in** / participate **in**", "*She succeeded **in** persuading him.*"),
                R("prevent / stop / discourage sb **from** -ing", "*Nothing prevented him **from** trying again.*"),
                R("suffer **from** / recover **from**", "*He's recovering **from** a virus.*"),
                R("cope **with** / comply **with** / deal **with**", "*The airline coped **with** the strike.*"),
                R("consist **of**", "*The team consists **of** five engineers.*"),
                R("wait **for** / search **for** / hope **for**", "*We're waiting **for** the results.*")
            )
        ),
        new LearnSection(
            "Adjective + preposition",
            new Table(
                ["Pattern", "Examples"],
                R("**of**: afraid, ashamed, aware, capable, fond, jealous, proud, tired", "*She's fond **of** classical music.*"),
                R("**at**: good, bad, brilliant, hopeless, skilled", "*He's brilliant **at** chess.*"),
                R("**in**: interested, involved, experienced", "*I'm not interested **in** politics.*"),
                R("**on**: keen, dependent, intent", "*She's keen **on** sailing.*"),
                R("**about**: angry, worried, excited, anxious, upset", "*I'm worried **about** the results.*"),
                R("**with**: angry (with sb), pleased, satisfied, disappointed, familiar", "*He was furious **with** us.* — angry **about** sth, angry **with** sb"),
                R("**for**: famous, responsible, ready, sorry, suitable, grateful", "*The region is famous **for** its wine.*"),
                R("**to**: similar, married, allergic, opposed, addicted, kind", "*My laptop is similar **to** yours.*"),
                R("**from**: different, absent, exempt, isolated", "*The result was different **from** what we expected.*")
            )
        ),
        new LearnSection(
            "Noun + preposition",
            new Table(
                ["Pattern", "Examples"],
                R("reason **for** / demand **for** / need **for**", "*There's little demand **for** these cars.*"),
                R("effect / influence / impact **on**", "*Tourism has a huge impact **on** the coast.*"),
                R("increase / rise / fall / drop **in**", "*a sharp rise **in** unemployment*"),
                R("solution / key / answer / threat **to**", "*There's no easy solution **to** this.*"),
                R("attitude **to/towards** / opinion **of**", "*a positive attitude **to** change*"),
                R("advantage / disadvantage **of**", "*The advantage **of** cycling is the price.*"),
                R("difficulty (in) / point (in) / success (in) + -ing", "*They had difficulty **in** finding tickets.*"),
                R("relationship **with** / difference **between** / contribution **to**", "*the difference **between** the two versions*"),
                R("lack **of** / ban **on**", "*a ban **on** smoking indoors*")
            ),
            new Examples(
                "*The accusation against him was dropped.* — accuse sb **of** but accusation **against**",
                "*Her success in business surprised everyone.* — succeed **in** but success **in**"
            )
        )
    );

    // ------------------------------------------------------------------ linking words

    private static readonly LearnLibrary.Topic LinkingWords = new(
        "linking-words", "Linking words", "Connectors by function — and the grammar that must follow each one.", "Vocabulary and usage",
        new LearnSection(
            "Contrast",
            new Table(
                ["Connector", "Followed by", "Example"],
                R("although / even though / though", "clause", "**Although it rained,** we walked."),
                R("despite / in spite of", "noun or -ing", "**Despite the rain,** … / **In spite of feeling tired,** …"),
                R("despite / in spite of the fact that", "clause", "**In spite of the fact that it rained,** …"),
                R("however / nevertheless / nonetheless", "new sentence", "It rained. **However,** we walked anyway."),
                R("whereas / while", "clause (comparing two facts)", "I love cities, **whereas** she prefers villages."),
                R("on the other hand / in contrast", "new sentence", "The north is wet. **In contrast,** the south is arid.")
            ),
            new Note("One connector per contrast: *~~Although it rained, but we walked.~~* Choose *although* or *but* — never both.")
        ),
        new LearnSection(
            "Cause and reason",
            new Table(
                ["Connector", "Followed by", "Example"],
                R("because", "clause", "We stayed in **because** it was freezing."),
                R("since / as", "clause (reason already known)", "**As** you know, prices are rising."),
                R("because of / due to / owing to", "noun or -ing", "**Due to fog,** all flights were cancelled."),
                R("due to / owing to", "after *be*", "The delay **was due to** fog."),
                R("thanks to", "noun (positive outcome)", "**Thanks to** her quick thinking, nobody was hurt."),
                R("on account of", "noun (formal)", "The match was postponed **on account of** the weather.")
            )
        ),
        new LearnSection(
            "Purpose",
            new Table(
                ["Connector", "Followed by", "Example"],
                R("to / in order to / so as to", "infinitive", "I left early **to avoid** the traffic."),
                R("so as not to / in order not to", "infinitive (negative)", "I spoke quietly **so as not to** wake the baby."),
                R("so that", "clause with can / could / will / would", "I left early **so that I could park**."),
                R("in case", "present or past simple (precaution)", "Take a map **in case you get lost**."),
                R("for + -ing", "what a thing is used for", "A knife is **for cutting**.")
            )
        ),
        new LearnSection(
            "Addition",
            new Table(
                ["Connector", "Followed by", "Example"],
                R("moreover / furthermore / in addition / what is more", "new sentence (formal)", "The car is fast. **Moreover,** it is cheap to run."),
                R("besides", "clause (informal)", "I'm not going. **Besides,** it's too far."),
                R("as well as", "noun or -ing", "**As well as** winning, she broke the record."),
                R("not only … but also", "clause — **inversion** when fronted", "**Not only did he win,** but he also set a record.")
            )
        ),
        new LearnSection(
            "Result",
            new Table(
                ["Connector", "Followed by", "Example"],
                R("so", "clause", "It was late, **so** we left."),
                R("therefore / consequently / as a result / thus", "new sentence (formal)", "Sales fell sharply. **Consequently,** two plants closed."),
                R("so + adjective / adverb + that", "clause", "It was **so hot that** we stayed indoors."),
                R("such (+ a/an) + noun + that", "clause", "It was **such a boring film that** I fell asleep.")
            )
        )
    );

    // ------------------------------------------------------------------ phrasal verbs

    private static readonly LearnLibrary.Topic PhrasalVerbs = new(
        "phrasal-verbs", "Phrasal verbs", "The exam-frequent phrasal verbs, grouped by particle, with a meaning and an example each.", "Vocabulary and usage",
        new LearnSection(
            "UP: arrive, appear, complete, invent",
            new Table(
                ["Verb", "Meaning", "Example"],
                R("turn up / show up", "arrive (often unexpectedly)", "He **turned up** an hour late."),
                R("come up", "(a problem, question) arise", "Something urgent **came up** at work."),
                R("bring up", "raise a child; mention a topic", "They **brought up** three kids. Don't **bring up** politics."),
                R("set up", "start (a business, organisation)", "She **set up** a design studio."),
                R("take up", "start a hobby or sport", "I've **taken up** climbing."),
                R("give up", "stop trying; quit", "He **gave up** smoking last year."),
                R("end up", "finally be or do something", "We **ended up** walking home."),
                R("grow up", "become an adult", "I **grew up** in Valencia."),
                R("make up", "invent (a story); reconcile", "She **made up** an excuse. They kissed and **made up**."),
                R("come up with", "produce (an idea, solution)", "Who **came up with** that plan?"),
                R("keep up with", "stay level with", "I can't **keep up with** the news cycle."),
                R("catch up with", "reach the same point as", "I need to **catch up with** my emails."),
                R("look up", "find (a word, number) in a reference", "**Look up** the word in a dictionary."),
                R("live up to", "meet (expectations)", "The film didn't **live up to** the hype."),
                R("put up with", "tolerate", "I won't **put up with** this noise.")
            )
        ),
        new LearnSection(
            "DOWN and OFF: stop, cancel, refuse",
            new Table(
                ["Verb", "Meaning", "Example"],
                R("break down", "(machine) stop working; (person) lose control", "The van **broke down** on the motorway."),
                R("let sb down", "disappoint", "He promised to help, then **let me down**."),
                R("turn down", "refuse; lower (volume, heat)", "She **turned down** the offer."),
                R("calm down", "become calm", "Just **calm down** and explain."),
                R("cut down on", "reduce", "I'm **cutting down on** sugar."),
                R("put down", "place; stop reading; criticise", "Put the phone **down** and listen."),
                R("set off", "start a journey", "We **set off** at dawn."),
                R("put off", "postpone; discourage", "Don't **put off** the dentist."),
                R("call off", "cancel", "They **called off** the strike."),
                R("take off", "(plane) leave the ground; remove; succeed fast", "Sales **took off** after the review."),
                R("let sb off", "not punish", "The judge **let him off** with a warning."),
                R("get by", "manage (with difficulty)", "We **get by** on one salary.")
            )
        ),
        new LearnSection(
            "OUT: discover, solve, result",
            new Table(
                ["Verb", "Meaning", "Example"],
                R("find out", "discover", "I **found out** the truth eventually."),
                R("work out", "solve; calculate; understand; exercise", "We'll **work out** a compromise."),
                R("point out", "mention, draw attention to", "She **pointed out** the risks."),
                R("turn out", "prove to be; happen in the end", "It **turned out** to be a hoax."),
                R("run out of", "have no more left", "We've **run out of** milk."),
                R("carry out", "perform (research, a task, a threat)", "The lab **carried out** the tests."),
                R("sort out", "organise; solve", "I need to **sort out** my visa."),
                R("stand out", "be clearly noticeable", "Her essay **stood out**."),
                R("drop out (of)", "leave school or a course", "He **dropped out** of law school."),
                R("come out", "be published or released", "Her novel **comes out** in May."),
                R("make out", "distinguish; claim", "I could barely **make out** the sign.")
            )
        ),
        new LearnSection(
            "BACK, ON, AWAY and more",
            new Table(
                ["Verb", "Meaning", "Example"],
                R("give away", "reveal (a secret); give free", "Don't **give away** the ending!"),
                R("throw away", "discard", "Don't **throw away** the receipt."),
                R("get away with", "escape punishment for", "He **got away with** a small fine."),
                R("pass away", "die (polite)", "Her grandfather **passed away** last month."),
                R("look back on", "remember, reflect on", "I **look back on** those years fondly."),
                R("hold on", "wait", "**Hold on** — I'm nearly ready."),
                R("carry on", "continue", "Carry **on** — I'm listening."),
                R("get on with", "have a good relationship with", "I **get on with** my colleagues."),
                R("go on", "continue; happen", "What's **going on** here?"),
                R("take on", "hire; accept (work, responsibility)", "They're **taking on** staff."),
                R("put on", "dress in; gain (weight)", "I've **put on** two kilos."),
                R("try on", "test clothes by wearing", "**Try on** the jacket before buying."),
                R("come across", "find by chance", "I **came across** my old diaries."),
                R("run into", "meet by chance", "I **ran into** Ana at the station."),
                R("get over", "recover from", "It took weeks to **get over** the flu."),
                R("go through", "experience; examine", "She's **going through** a hard time."),
                R("look into", "investigate", "The committee will **look into** the complaint."),
                R("look forward to + -ing", "anticipate with pleasure", "I **look forward to hearing** from you.")
            )
        )
    );

    // ------------------------------------------------------------------ word formation

    private static readonly LearnLibrary.Topic WordFormation = new(
        "word-formation", "Word formation", "Prefixes, suffixes, spelling rules and the base forms examiners love to test.", "Vocabulary and usage",
        new LearnSection(
            "Negative prefixes",
            new Table(
                ["Prefix", "Rule", "Examples"],
                R("un-", "the default, fits many roots", "*unhappy, unfair, unusual, undo*"),
                R("in-", "elsewhere (Latin roots)", "*incorrect, indirect, insensitive*"),
                R("im-", "before p, b, m", "*impossible, impolite, immature, imbalance*"),
                R("il-", "before l", "*illogical, illegal, illiterate*"),
                R("ir-", "before r", "*irregular, irresponsible, irrational*"),
                R("dis-", "verbs and adjectives", "*dishonest, disagree, disobey, disadvantage*"),
                R("mis-", "wrongly", "*misunderstand, mislead, mispronounce*"),
                R("-less", "suffix = without — a new word, not the opposite", "*harmless, endless, jobless* — *priceless* means invaluable!")
            ),
            new Note("There is no rule for choosing *un-* vs *in-*: you must know the word. *unhappy* but *unpleasant* — both *un-*; *incorrect* but *uninteresting*.")
        ),
        new LearnSection(
            "Noun suffixes",
            new Table(
                ["Suffix", "Examples"],
                R("-ment", "*argument, improvement, arrangement*"),
                R("-tion / -sion / -ation", "*decision, education, promotion*"),
                R("-ance / -ence", "*performance, difference, confidence*"),
                R("-ity", "*possibility, responsibility, curiosity*"),
                R("-ness", "*kindness, awareness, illness*"),
                R("-ship / -hood / -age", "*friendship, childhood, marriage*"),
                R("-ist / -er / -or / -ian", "*artist, trainer, actor, mathematician*"),
                R("-ee (person acted on)", "*employee, trainee, interviewee*")
            )
        ),
        new LearnSection(
            "Adjective suffixes",
            new Table(
                ["Suffix", "Examples"],
                R("-ful / -less", "*careful / careless, useful / useless*"),
                R("-ous", "*famous, dangerous, ambitious*"),
                R("-ive", "*attractive, creative, effective*"),
                R("-able / -ible", "*comfortable, dependable, visible, accessible*"),
                R("-al", "*natural, professional, traditional*"),
                R("-y / -ish", "*rainy, salty; childish, reddish*"),
                R("-ed / -ing", "*bored / boring, thrilled / thrilling*")
            )
        ),
        new LearnSection(
            "Verb and adverb suffixes",
            new Table(
                ["Suffix", "Examples"],
                R("-ise / -ize (verbs)", "*modernise, organise, realise*"),
                R("-ify (verbs)", "*simplify, clarify, justify*"),
                R("-en (verbs)", "*widen, strengthen, shorten, darken*"),
                R("-ly (adverbs)", "*quickly, seriously, remarkably*")
            ),
            new Note("Adverb traps: *public → publicly* (no *e*); *full → fully* (one *l*). Adjectives ending in *-ly* (*friendly, lovely, likely*) have no adverb form — say *in a friendly way*. And *hard → hard*; *hardly* means almost not.")
        ),
        new LearnSection(
            "Spelling rules",
            new Bullets(
                "Drop final *-e* before a vowel suffix: *create → creating, argue → arguing*.",
                "But many nouns keep it: *arrangement, management* — while others lose it: *argument, truly, wisdom*.",
                "*-y* becomes *-i* before a suffix: *easy → easily, heavy → heavier* (vowel + y keeps it: *enjoy → enjoying*).",
                "Double the final consonant after a short stressed vowel: *begin → beginning, big → biggest, refer → referred*."
            )
        ),
        new LearnSection(
            "Classic traps: irregular base forms",
            new Table(
                ["Verb / base", "Noun / derived form"],
                R("advise", "ad**vice** (noun) — *advise* rhymes with *wise*"),
                R("practise (BrE verb)", "pra**ctice** (noun)"),
                R("succeed", "success, successful"),
                R("choose", "choice"),
                R("explain", "expla**nation**"),
                R("maintain", "mainte**nance**"),
                R("high / deep / strong / long", "height, depth, strength, length"),
                R("die / believe / prove", "death, belief, proof")
            )
        )
    );

    // ------------------------------------------------------------------ confusable words

    private static readonly LearnLibrary.Topic ConfusableWords = new(
        "confusable-words", "Confusable words", "The classic C1 pairs, side by side — one line each.", "Vocabulary and usage",
        new LearnSection(
            "Pairs that fool even strong candidates",
            new Table(
                ["Pair", "Difference", "Example"],
                R("affect / effect", "affect = verb, influence; effect = noun, result", "The weather **affects** my mood. It had a calming **effect**."),
                R("advice / advise", "advice = noun; advise = verb", "Her **advice** was useful. She **advised** me to wait."),
                R("practice / practise (BrE)", "practice = noun; practise = verb", "Football **practice** is on Monday. We **practise** daily. (AmE: *practice* for both.)"),
                R("principal / principle", "principal = main, head; principle = rule, belief", "The **principal** reason / against my **principles**"),
                R("complement / compliment", "complement = completes; compliment = praise", "The wine **complements** the meal. She **complimented** my cooking."),
                R("lose / loose", "lose = misplace (rhymes with *shoes*); loose = not tight (rhymes with *goose*)", "Don't **lose** the key. The bolt is **loose**."),
                R("rise / raise", "rise (rose, risen) = go up by itself; raise = lift something else", "Prices **rose**. They **raised** prices."),
                R("remember / remind", "you remember yourself; somebody/something reminds you", "He **reminded** me to call. I **remembered** to call."),
                R("personal / personnel", "personal = private; personnel = staff", "**Personal** belongings. The **personnel** department."),
                R("economic / economical", "economic = about the economy; economical = saves money", "**Economic** growth. An **economical** car."),
                R("historic / historical", "historic = important in history; historical = about the past", "A **historic** victory. **Historical** documents."),
                R("sensible / sensitive", "sensible = reasonable; sensitive = reacts easily, feels deeply", "A **sensible** decision. **Sensitive** skin."),
                R("fun / funny", "fun = enjoyable; funny = makes you laugh", "The fair was great **fun**. A **funny** joke."),
                R("lend / borrow", "lend = give temporarily; borrow = take temporarily", "Can you **lend** me a pen? May I **borrow** one?"),
                R("win / beat", "win a game, prize, race; beat an opponent", "We **beat** them 3–0 and **won** the cup."),
                R("say / tell", "say sth (to sb); tell sb sth", "She **said** nothing. She **told** me a secret."),
                R("trip / journey / travel", "trip = journey + stay, countable; journey = the travelling; travel = the activity, uncountable", "A business **trip**. A long **journey**. **Travel** broadens the mind."),
                R("desert / dessert", "desert = dry land / abandon; dessert = sweet course", "The Sahara **Desert**. What's for **dessert**?")
            )
        )
    );

    // ------------------------------------------------------------------ prepositional phrases

    private static readonly LearnLibrary.Topic PrepositionalPhrases = new(
        "prepositional-phrases", "Prepositional phrases", "Fixed phrases: in time or on time, in the end or at the end, and the rest of the family.", "Vocabulary and usage",
        new LearnSection(
            "Time: in / on / at / by",
            new Table(
                ["Phrase", "Meaning", "Example"],
                R("in time (for / to)", "early enough", "We arrived **in time for** the start."),
                R("on time", "punctual, as scheduled", "The train left **on time**."),
                R("at last", "finally, with relief", "**At last**, the results are out."),
                R("in the end", "finally, after everything", "**In the end**, we stayed at home."),
                R("at the end (of)", "final point of something", "**At the end of** the film, everyone cried."),
                R("in advance", "beforehand", "Book **in advance** to save money."),
                R("at once / right away", "immediately", "Call me **at once**."),
                R("for the time being", "for now", "**For the time being**, nothing changes.")
            ),
            new Note("*In the end* = final outcome (like *eventually*); *at the end of* needs an object: *at the end of the week*.")
        ),
        new LearnSection(
            "Degree and comparison",
            new Table(
                ["Phrase", "Meaning", "Example"],
                R("by far", "by a large margin, with superlatives", "She's **by far** the best player."),
                R("by heart", "from memory", "I learnt the poem **by heart**."),
                R("by chance / by accident / by mistake", "not planned / wrongly", "I met her **by chance**. I took your bag **by mistake**."),
                R("on purpose", "deliberately", "He did it **on purpose**."),
                R("at least", "not less than", "**At least** a hundred people came."),
                R("in general / on the whole", "mostly, usually", "**On the whole**, reviews were positive."),
                R("in fact / as a matter of fact", "actually", "**In fact**, he was early."),
                R("on average / in total", "typically / altogether", "**On average**, we sell fifty a day."),
                R("for a change / for good", "for variety / permanently", "Let's eat out **for a change**. She's back **for good**.")
            )
        ),
        new LearnSection(
            "States and situations",
            new Table(
                ["Phrase", "Meaning", "Example"],
                R("under threat / pressure / discussion / way", "in a state of", "The castle is **under threat**. A plan is **under way**."),
                R("beyond doubt / recognition / repair", "past a limit", "The car was damaged **beyond repair**."),
                R("out of the question", "impossible, not negotiable", "Another delay is **out of the question**."),
                R("out of reach / order / stock / breath / work", "not available or functioning", "The lift is **out of order**."),
                R("in danger / at risk", "unsafe", "The species is **at risk**."),
                R("in a hurry / in a rush", "rushing", "I was **in a hurry** and forgot it."),
                R("on strike / on duty / on business / on holiday", "engaged in an activity", "Judges are **on strike**."),
                R("for sale / on sale", "available to buy (AmE: at reduced price)", "The house is **for sale**."),
                R("in common / in detail / in conclusion", "shared / thoroughly / finally", "We have a lot **in common**."),
                R("on second thoughts", "reconsidering (BrE)", "**On second thoughts**, make it two.")
            )
        ),
        new LearnSection(
            "Two in one: time and degree pairs",
            new Examples(
                "*We got there just **in time** — it was starting.* vs *The flight left **on time**.*",
                "*by far the best player* — **by far** can also follow: *the best player **by far***."
            )
        )
    );

    /// <summary>All topics in canonical order. Declared after the topics it lists so
    /// static initialisation sees non-null values.</summary>
    public static readonly LearnLibrary.Topic[] All =
    [
        Prepositions, LinkingWords, PhrasalVerbs, WordFormation, ConfusableWords, PrepositionalPhrases,
    ];
}
