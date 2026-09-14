using static PracticingCAE.Web.Components.Pages.LearnContent.LearnBlock;
using static PracticingCAE.Web.Components.Pages.LearnContent.LearnText;

namespace PracticingCAE.Web.Components.Pages.LearnContent;

/// <summary>Grammar cheat sheets, in canonical order.</summary>
public static class GrammarTopics
{
    // ------------------------------------------------------------------ articles

    private static readonly LearnLibrary.Topic Articles = new(
        "articles", "Articles", "a/an, the or nothing: a decision route, reference tables and the fixed phrases worth memorising.", "Grammar",
        new LearnSection(
            "Decision route in four steps",
            new Table(
                ["Step", "Question", "Article", "Example"],
                R("**1.**", "Plural or uncountable, general statement?", "zero article", "*Dogs are loyal. Water boils at 100°C. Advice is cheap.*"),
                R("**2.**", "Singular countable, first mention or just one of many?", "**a / an**", "*She bought a hat. He's a nurse. It costs €5 a kilo.*"),
                R("**3.**", "Do speaker and listener both know exactly which one — already mentioned, unique, or defined by a phrase?", "**the**", "*The hat she bought. The moon. The roof of the barn.*"),
                R("**4.**", "Specific, but plural or uncountable?", "**the** (or my, these…)", "*The dogs next door. The water in this jug. Her advice was priceless.*")
            ),
            new Note("A singular countable noun can almost never stand alone: *~~Car is expensive.~~* — say *A car is expensive* (one of many) or *The car is expensive* (we both know which).")
        ),
        new LearnSection(
            "Where 'the' earns its keep",
            new Table(
                ["Use", "With 'the'", "Without"],
                R("second and later mention", "*A car stopped and **the** driver got out.*", "*~~A driver got out~~* — breaks the link to the car"),
                R("only one in the situation", "*Close **the** door, please. **The** kettle's boiling.*", "*~~A kettle's boiling~~* — there is one kettle"),
                R("unique things", "**the** sun, the moon, the internet, the equator", "*~~a sun~~*"),
                R("superlatives, ordinals, only, same", "**the** best film, the first time, the only chance, the same day", "*~~best film I've seen~~*"),
                R("adjective = a whole group", "**the** rich, the unemployed, the young", "*~~rich are getting richer~~*"),
                R("nationalities ending in -ese / -sh / -ch", "**the** Japanese, the British, the French", "*Germans* (most others: no *the*)"),
                R("inventions and species", "**the** telephone, the computer, the tiger", "*~~telephone changed the world~~*"),
                R("musical instruments after *play*", "She plays **the** violin.", "*~~She plays violin.~~* (exam English)"),
                R("media and places of culture", "on **the** radio, on **the** internet, at **the** cinema, **the** press", "on *TV*, on *social media* (no article)"),
                R("named hotels, theatres, museums", "**the** Ritz, the Odeon, the Tate", "Buckingham Palace (name includes it)"),
                R("families", "**the** Smiths, the Kennedys", "*~~Smiths are coming~~*"),
                R("parts of the day", "in **the** morning / afternoon / evening", "at *night*, at *noon*, at *midnight*"),
                R("dates and decades", "**the** 3rd of May, **the** 1990s", "*3 May* (written form)"),
                R("prepositional place phrases", "in **the** corner of a room, **on the** way", "at *home*, in *bed*")
            )
        ),
        new LearnSection(
            "When nothing is the right answer",
            new Table(
                ["Zero-article case", "Correct", "Watch out"],
                R("general plurals and uncountables", "*Cats sleep a lot. Sugar is bad for you.*", "*The sugar* only if a specific sugar is meant"),
                R("languages and school subjects", "*She studies medicine and speaks Chinese.*", "the *Chinese language* (with *language*)"),
                R("meals", "*We had dinner at eight. Have breakfast.*", "*a big breakfast*, *the dinner she cooked*"),
                R("sports and games", "*play football, play chess*", "*a game of chess*"),
                R("bed, church, prison, school, work, home", "*go to bed, at school, at work*", "*in the school building* (the place, not the institution)"),
                R("transport: by + noun", "*by car, by bus, by train, on foot*", "*in the car, on the bus* (a specific one)"),
                R("most proper nouns", "*Europe, Lake Geneva, Mount Fuji, Baker Street, Hyde Park*", "*the Alps, the Netherlands, the Sahara* (see below)"),
                R("titles with a name", "*Queen Elizabeth, Professor Brown*", "*the Queen of England* (no name)"),
                R("society in general", "*People are selfish. Society has changed.*", "*~~the society~~* unless a specific society is meant")
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
                R("go to church / in church", "to worship", "*They go to church every Sunday.*"),
                R("go to court", "as a party in a legal case", "*The company is going to court over the sacking.*"),
                R("at sea", "sailing, away on a ship", "*He spends months at sea.*"),
                R("by the sea", "next to the coast", "*A cottage by the sea*"),
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
                R("most street and place names: *Oxford Street, Victoria Station*", "deserts and gulfs: *the Sahara, the Gulf of Mexico*"),
                R("parks: *Hyde Park, Central Park*", "straits, poles, equator: *the Straits of Gibraltar, the North Pole, the equator*"),
                R("—", "a few fixed cases: *the Hague, the Amazon, the Gambia*")
            ),
            new Note("Motorways and numbered roads take *the*: *the M25, the A5*. Points on the globe too: *the equator, the North Pole*.")
        ),
        new LearnSection(
            "a or an: sound, not spelling",
            new Bullets(
                "**an** before a vowel *sound*: *an hour, an honest man, an MP, an SOS, an X-ray*",
                "**a** before a consonant *sound*: *a university, a one-way ticket, a European city, a U-turn*",
                "Abbreviations follow the sound: *an FBI agent* but *a BA degree*."
            )
        ),
        new LearnSection(
            "Fixed phrases: learn them as they are",
            new Table(
                ["Phrase", "Article", "Example"],
                R("a few / a little", "a", "*A few friends came. Add a little salt.*"),
                R("a lot of / lots of", "a", "*A lot of people complained.*"),
                R("a couple of", "a", "*I'll be back in a couple of minutes.*"),
                R("a great deal of", "a", "*A great deal of money was spent.*"),
                R("a pity / a shame", "a", "*What a pity! It's a shame we missed it.*"),
                R("a pleasure", "a", "*It's a pleasure to meet you.*"),
                R("have a look / a rest / a shower / a cold / an idea / a word", "a/an", "*Let me have a look. I've had an idea.*"),
                R("in a hurry / in a mess / in a good mood", "a", "*She's in a good mood today.*"),
                R("as a result", "a", "*As a result, sales doubled.*"),
                R("a most + adjective (= very)", "a", "*It was a most unusual story.*"),
                R("once / twice / three times a week", "a", "*Twice a week, three times a day*"),
                R("what a + noun", "a", "*What a disaster! What a lovely surprise!*"),
                R("the more… the more", "the", "*The more you practise, the easier it gets.*"),
                R("the same", "the", "*We went to the same school.*"),
                R("the whole", "the", "*The whole truth, the whole trip*"),
                R("the rest of", "the", "*The rest of us waited outside.*"),
                R("play the piano / the violin", "the", "*He plays the cello.*"),
                R("the radio / the internet", "the", "*I heard it on the radio.*"),
                R("the cinema / the theatre", "the", "*Shall we go to the cinema?*"),
                R("in town vs the town", "zero / the", "*She's in town today.* (nearby urban centre) — *We wandered round the old town.* (a specific one)"),
                R("in future vs in the future", "zero / the", "*In future, please be punctual.* (= from now on) — *In the future, cars may drive themselves.*"),
                R("at school vs the school", "zero / the", "*The kids are at school.* (studying) — *I'll meet you at the school.* (the building)")
            )
        ),
        new LearnSection(
            "Typical exam traps",
            new DoDont(
                ["*She's at university studying law.*", "*He was elected president.* (unique role)", "*The life of a farmer is hard.* (specific life)"],
                ["*~~She's at the university studying law.~~*", "*~~He was elected a president.~~*", "*~~Life of a farmer is hard.~~*"])
        )
    );

    // ------------------------------------------------------------------ tenses

    private static readonly LearnLibrary.Topic Tenses = new(
        "tenses", "Tenses", "All twelve tenses with forms, uses, signal words and examples — plus state verbs and every future form.", "Grammar",
        new LearnSection(
            "The twelve tenses",
            new Table(
                ["Tense", "Form", "Core use", "Signal words", "Example"],
                R("Present simple", "work / works", "habits, facts, timetables, permanent situations", "always, usually, every day, never, on Mondays", "*The gallery opens at ten.*"),
                R("Present continuous", "am / is / are working", "happening now; temporary; fixed arrangement; annoyance with *always*", "now, at the moment, this week, these days, Look!", "*I'm staying with friends this week.*"),
                R("Present perfect", "have / has worked", "past action with present result; experience; unfinished time", "just, already, yet, ever, never, since, for, so far, recently", "*She has just left. I've seen that film twice.*"),
                R("Present perfect continuous", "have / has been working", "activity continuing up to now; recent activity with visible evidence", "for, since, all day, How long…?", "*It's been raining — the pavement is wet.*"),
                R("Past simple", "worked", "finished action at a finished time", "yesterday, ago, in 2019, last week", "*We moved here in 2015.*"),
                R("Past continuous", "was / were working", "background action; action in progress interrupted by another", "while, as, when, at 8 pm yesterday", "*I was cooking when the phone rang.*"),
                R("Past perfect", "had worked", "the earlier of two past events", "before, by the time, after, already", "*The train had left by the time we arrived.*"),
                R("Past perfect continuous", "had been working", "duration up to a past point", "for two hours before…, had been -ing when…", "*He had been waiting for an hour when she finally came.*"),
                R("Future simple", "will work", "predictions, promises, instant decisions, offers", "probably, I think, tomorrow, tonight", "*I'll help you with those bags.*"),
                R("Future continuous", "will be working", "in progress at a future time; polite enquiry about plans", "this time tomorrow, at 5 pm on Monday", "*This time tomorrow I'll be flying to Oslo.*"),
                R("Future perfect", "will have worked", "completed by a future point", "by Monday, by 2030, by then", "*By May they will have sold the house.*"),
                R("Future perfect continuous", "will have been working", "duration up to a future point", "for + period + by", "*By June I'll have been working here for ten years.*")
            )
        ),
        new LearnSection(
            "State verbs vs action verbs",
            new Para("State verbs describe conditions, feelings and thoughts, not actions, so they avoid continuous forms. Learn the groups:"),
            new Bullets(
                "**emotion**: like, love, hate, want, need, prefer, mind, adore",
                "**perception**: see, hear, smell, taste, feel, notice, recognise",
                "**thought**: know, believe, mean, understand, remember, forget, realise, suppose, doubt, agree",
                "**possession and content**: own, belong, contain, include, possess, owe",
                "**being and seeming**: seem, appear, resemble, look like, cost, weigh, fit, suit, matter, depend, exist"
            ),
            new Table(
                ["Verb", "State meaning (no continuous)", "Action use (continuous possible)"],
                R("have", "*She has a villa in Spain.* (own)", "*She's having lunch / a shower / a great time.*"),
                R("think", "*I think you're right.* (opinion)", "*I'm thinking about your offer.* (considering)"),
                R("see", "*I see what you mean.* (understand)", "*I'm seeing the dentist at four.* (meeting)"),
                R("taste", "*The soup tastes salty.*", "*The chef is tasting the soup.*"),
                R("smell", "*The flat smells of paint.*", "*She's smelling the roses.*"),
                R("look", "*You look tired.* (seem)", "*I'm looking at the photos.*"),
                R("appear", "*He appears to be upset.* (seems)", "*He's appearing at the Opera House.* (performing)"),
                R("weigh", "*It weighs two kilos.*", "*She's weighing the parcels.*"),
                R("fit", "*The dress fits you perfectly.*", "*They're fitting a new kitchen.* (installing)"),
                R("be", "*He is lazy.* (character)", "*He's being lazy today.* (behaving, just now)")
            )
        ),
        new LearnSection(
            "Future forms compared",
            new Table(
                ["Form", "Use", "Example"],
                R("will + base", "prediction; promise; instant decision; offer", "*I'll have the pasta, please.*"),
                R("be going to", "intention decided before speaking; prediction from evidence", "*We're going to repaint the kitchen. Look at those clouds — it's going to snow.*"),
                R("present continuous", "fixed arrangement, usually involving other people", "*I'm seeing the bank manager on Tuesday.*"),
                R("present simple", "timetables, schedules, programmes", "*The ferry leaves at 6.15.*"),
                R("future continuous", "in progress at a future moment; neutral question about plans", "*Will you be using the car tonight?*"),
                R("future perfect", "finished by a point in the future", "*We'll have finished by lunchtime.*"),
                R("be about to / on the point of", "imminent", "*The plane is about to take off.*"),
                R("be to", "official arrangements, formal news", "*The President is to visit Warsaw in May.*")
            ),
            new Note("*will* never appears in a time clause: *~~I'll call you when I will arrive.~~* Say *when I arrive / as soon as it stops / before we leave* — present tense for future meaning.")
        ),
        new LearnSection(
            "Present perfect vs past simple",
            new Bullets(
                "Present perfect: the time is unfinished or unimportant, the result matters now — *I have lost my keys* (still lost).",
                "Past simple: the time is finished and usually stated — *I lost them yesterday*.",
                "*for* + period works with both; *since* + point in time needs a perfect form.",
                "*gone to* = still there; *been to* = visited and returned."
            ),
            new Table(
                ["Adverb / expression", "Tense it demands", "Example"],
                R("yesterday, last week, in 2010, ago", "past simple", "*~~I have seen him yesterday.~~* → *I saw him yesterday.*"),
                R("today, this week, this morning (day not over)", "present perfect (or past simple once the time is over)", "*Have you seen Maria today?* — said at 6 pm; *Did you see Maria this morning?* — said at 8 pm"),
                R("ever, never, already, yet, so far, recently", "present perfect", "*It's the best meal I've ever had.*"),
                R("just (very recently, BrE)", "present perfect (AmE: past simple)", "*The taxi has just left.*"),
                R("How long…? + for / since", "perfect forms", "*How long have you been waiting?*")
            )
        ),
        new LearnSection(
            "Simple says permanent, continuous says temporary",
            new Examples(
                "*I live in Berlin.* (permanent) vs *I'm living in Berlin for the summer.* (temporary)",
                "*What do you do?* (job) vs *What are you doing?* (right now)",
                "*The bridge weighs two tonnes.* (fact) vs *The surgeon is weighing the implant.* (in progress)",
                "*She usually works days.* (routine) vs *She's working nights this month.* (temporary exception)"
            )
        )
    );

    // ------------------------------------------------------------------ conditionals

    private static readonly LearnLibrary.Topic Conditionals = new(
        "conditionals", "Conditionals", "Zero to third and mixed patterns, alternatives to if, wish-forms and inverted conditionals.", "Grammar",
        new LearnSection(
            "The five patterns",
            new Table(
                ["Type", "If-clause", "Main clause", "Meaning", "Example"],
                R("Zero", "present simple", "present simple", "general truth; the result always follows", "*If you heat ice, it melts.*"),
                R("First", "present simple", "will / can / might / imperative", "real future possibility", "*If it rains, we'll take a taxi. If you finish early, call me.*"),
                R("Second", "past simple", "would / could / might + base", "unreal present or unlikely future", "*If I had more time, I would learn Greek. If she apologised, I might forgive her.*"),
                R("Third", "past perfect", "would / could / might have + V3", "unreal past; regret", "*If she had revised, she would have passed.*"),
                R("Mixed", "past perfect + would + base", "—", "past cause, present result", "*If I had taken that job, I would be rich now.*")
            ),
            new Table(
                ["Type", "If-clause", "Main clause", "Meaning", "Example"],
                R("Mixed (2)", "past simple + would have + V3", "—", "present cause, past result", "*If he weren't so shy, he would have asked her out.*")
            ),
            new Note("Never put **will** or **would** in the if-clause: *~~If it will rain…~~* Use *If it rains… / If it rained…* The exception is *will* meaning 'insist / be willing': *If you will sign here, sir…*")
        ),
        new LearnSection(
            "Alternatives to if",
            new Table(
                ["Connector", "Grammar that follows", "Meaning", "Example"],
                R("unless", "positive clause", "if…not", "*Unless you hurry, we'll miss it.* (= If you don't hurry…)"),
                R("provided / providing (that)", "clause", "only if (condition imposed)", "*You can borrow the car provided you fill the tank.*"),
                R("as long as", "clause", "only if; on the condition that", "*Stay as long as you like.*"),
                R("on condition that", "clause", "formal 'only if'", "*He was released on condition that he left the country.*"),
                R("supposing / suppose", "clause", "what if… (open question)", "*Supposing the flight is cancelled, what then?*"),
                R("in case", "present / past clause", "as a precaution (different meaning!)", "*Take a jacket in case it gets cold.*"),
                R("in case of", "noun", "warning: if…happens", "*In case of fire, break the glass.*"),
                R("otherwise / or (else)", "new clause", "if not", "*Leave now, otherwise you'll be late.*"),
                R("but for + noun", "noun phrase", "if it were not for (formal, often with inversion)", "*But for your help, I would have failed.*")
            ),
            new Note("*In case* ≠ *if*: *I'll take an umbrella in case it rains* (take it now as a precaution) vs *I'll take a taxi if it rains* (only then). And *unless* already contains *not*: *~~Unless you don't hurry…~~*")
        ),
        new LearnSection(
            "wish and if only",
            new Table(
                ["Form", "Use", "Example"],
                R("wish / if only + past simple", "regret about the present", "*I wish I knew the answer. If only we had a garden!*"),
                R("wish / if only + past perfect", "regret about the past", "*If only I had booked earlier!*"),
                R("wish + would", "annoyance; wanting someone else to change", "*I wish you would stop tapping your pen.*"),
                R("wish + could", "regret about ability", "*I wish I could sing.*"),
                R("would rather + past", "wanting someone else to act differently", "*I'd rather you didn't smoke in here.*"),
                R("it's (high) time + past", "something should already be happening", "*It's time we left.*")
            ),
            new Para("*I wish I were…* is the traditional form; *was* is common in speech. *If only* is stronger than *wish*. Never *~~I wish I have…~~*")
        ),
        new LearnSection(
            "Inverted conditionals (formal)",
            new Table(
                ["Plain", "Inverted"],
                R("*If you should need help, call me.*", "**Should you need help,** call me."),
                R("*If I were in your position, I would refuse.*", "**Were I in your position,** I would refuse."),
                R("*If it were not for your support…*", "**Were it not for** your support…"),
                R("*If I had known, I would have come.*", "**Had I known,** I would have come."),
                R("*If he had not been so tired…*", "**Had he not been** so tired…"),
                R("*If it had not been for the alarm…*", "**Had it not been for** the alarm, we'd have overslept.")
            )
        ),
        new LearnSection(
            "Typical exam traps",
            new DoDont(
                ["*If I had known, I would have helped.*", "*Unless it rains, the match is on.*", "*I wish I could come.*"],
                ["*~~If I would have known, I would have helped.~~*", "*~~Unless it doesn't rain…~~*", "*~~I wish I can come.~~*"])
        )
    );

    // ------------------------------------------------------------------ verb patterns

    private static readonly LearnLibrary.Topic VerbPatterns = new(
        "verb-patterns", "Verb patterns", "-ing or to-infinitive: a lookup table of 50+ verbs, meaning-change verbs, bare infinitives and preposition + -ing.", "Grammar",
        new LearnSection(
            "The patterns at a glance",
            new Table(
                ["Pattern", "Looks like", "Example"],
                R("verb + -ing", "*enjoy, avoid, keep…*", "*I enjoy **reading** in bed.*"),
                R("verb + to-infinitive", "*decide, hope, manage…*", "*We decided **to walk**.*"),
                R("verb + object + to-infinitive", "*want, tell, advise…*", "*I want **you to listen**.*"),
                R("verb + object + bare infinitive", "*make, let, help…*", "*She made **me wait**.*"),
                R("verb + object + -ing", "*keep, catch, spend time…*", "*Sorry to keep **you waiting**.*"),
                R("verb + preposition + -ing", "*insist on, object to…*", "*He insisted **on paying**.*"),
                R("both, no change of meaning", "*like, start, continue…*", "*It started **raining / to rain**.*")
            ),
            new Note("In the tables below **V** = verb, **obj** = object, **base** = bare infinitive (no *to*).")
        ),
        new LearnSection(
            "50 popular verbs and the pattern each one takes",
            new Table(
                ["Verb", "Pattern", "Example"],
                R("admit", "V + -ing", "*He admitted copying the essay.*"),
                R("advise", "V + obj + to-inf", "*I advised her to take a coat.*"),
                R("afford", "V + to-inf", "*We can't afford to move house.*"),
                R("agree", "V + to-inf", "*She agreed to lend me the tent.*"),
                R("aim", "V + to-inf", "*We aim to launch in May.*"),
                R("allow", "V + obj + to-inf", "*They don't allow visitors to take photos.*"),
                R("appreciate", "V + -ing", "*I'd appreciate hearing from you soon.*"),
                R("arrange", "V + to-inf", "*I've arranged to work from home.*"),
                R("avoid", "V + -ing", "*Try to avoid making assumptions.*"),
                R("can't help", "V + -ing", "*She couldn't help noticing the scar.*"),
                R("can't stand", "V + -ing", "*I can't stand queueing.*"),
                R("choose", "V + to-inf", "*He chose to say nothing.*"),
                R("consider", "V + -ing", "*We're considering relocating.*"),
                R("decide", "V + to-inf", "*I decided to take the later train.*"),
                R("delay", "V + -ing", "*They delayed publishing the figures.*"),
                R("deny", "V + -ing", "*She denied taking the files.*"),
                R("deserve", "V + to-inf", "*The team deserved to win.*"),
                R("dislike", "V + -ing", "*He dislikes being photographed.*"),
                R("encourage", "V + obj + to-inf", "*Teachers encouraged us to ask questions.*"),
                R("enjoy", "V + -ing", "*We enjoyed walking along the canal.*"),
                R("expect", "V + obj + to-inf", "*I expect you to be punctual.*"),
                R("fancy", "V + -ing", "*Do you fancy going for a swim?*"),
                R("finish", "V + -ing", "*Have you finished packing?*"),
                R("force", "V + obj + to-inf", "*The storm forced us to turn back.*"),
                R("help", "V + obj + (to-)inf", "*Can you help me (to) carry this?*"),
                R("hope", "V + to-inf", "*They hope to open a second shop.*"),
                R("imagine", "V + -ing", "*Imagine winning the lottery.*"),
                R("insist on", "V + prep + -ing", "*He insisted on paying for dinner.*"),
                R("intend", "both, no change", "*We intend selling / to sell the flat.*"),
                R("involve", "V + -ing", "*The job involves a lot of travelling.*"),
                R("justify", "V + -ing", "*Nothing justifies raising prices like that.*"),
                R("keep", "V + -ing", "*Sorry — he kept talking.*"),
                R("keep / catch + obj", "V + obj + -ing", "*She kept me waiting. He caught me looking.*"),
                R("like", "both (*would like* + to)", "*I like hiking. I'd like to hike in Nepal.*"),
                R("long", "V + to-inf", "*She longed to see the sea again.*"),
                R("look forward to", "V + prep + -ing", "*I look forward to hearing from you.*"),
                R("make", "V + obj + base", "*They made him rewrite the report.*"),
                R("manage", "V + to-inf", "*Did you manage to fix the tap?*"),
                R("mention", "V + -ing", "*She mentioned meeting him in Oslo.*"),
                R("mind", "V + -ing", "*Would you mind opening the window?*"),
                R("miss", "V + -ing", "*I miss cooking for friends.*"),
                R("object to", "V + prep + -ing", "*I object to being charged twice.*"),
                R("offer", "V + to-inf", "*He offered to drive us home.*"),
                R("plan", "V + to-inf", "*We're planning to cycle there.*"),
                R("postpone", "V + -ing", "*Let's postpone deciding until Monday.*"),
                R("practise", "V + -ing", "*Practise parking between the cones.*"),
                R("prefer", "both (*would prefer* + to)", "*I prefer walking to driving. I'd prefer to drive.*"),
                R("pretend", "V + to-inf", "*He pretended not to hear.*"),
                R("promise", "V + to-inf", "*I promise to keep it secret.*"),
                R("recall", "V + -ing", "*I recall locking the door.*"),
                R("recommend", "V + -ing (or *that*)", "*I recommend taking the coast road.*"),
                R("refuse", "V + to-inf", "*She refused to comment.*"),
                R("remind", "V + obj + to-inf", "*Remind me to water the plants.*"),
                R("risk", "V + -ing", "*Don't risk losing your deposit.*"),
                R("seem", "V + to-inf", "*The flight seems to be delayed.*"),
                R("spend time / waste time", "V + obj + -ing", "*I spent hours rewriting it. Don't waste time arguing.*"),
                R("start / begin / continue", "both, no change", "*It started raining / to rain.*"),
                R("suggest", "V + -ing", "*She suggested ordering pizza.*"),
                R("teach", "V + obj + to-inf", "*Dad taught me to swim.*"),
                R("tell", "V + obj + to-inf", "*The doctor told him to rest.*"),
                R("tend", "V + to-inf", "*Prices tend to rise in July.*"),
                R("threaten", "V + to-inf", "*They threatened to evict the tenants.*"),
                R("want", "V + obj + to-inf", "*I want you to meet my parents.*"),
                R("warn", "V + obj + to-inf", "*They warned us not to swim there.*"),
                R("would like / love / prefer", "V + to-inf", "*I'd love to join you.*")
            )
        ),
        new LearnSection(
            "Verbs that change meaning",
            new Table(
                ["Verb", "+ -ing means", "+ to-inf means", "Examples"],
                R("stop", "quit the activity", "pause in order to do it", "*She stopped smoking.* / *He stopped to buy a paper.*"),
                R("remember", "memory of an earlier action", "not forget to do it", "*I remember posting the letter.* / *Remember to post the letter.*"),
                R("forget", "forgot that it happened", "failed to do it", "*I'll never forget visiting Kyoto.* / *She forgot to lock the door.*"),
                R("regret", "be sorry about the past", "polite formula for bad news", "*I regret selling the house.* / *We regret to inform you…*"),
                R("try", "do it as an experiment", "make an effort", "*Try restarting the router.* / *I tried to open it, but it stuck.*"),
                R("mean", "involve", "intend", "*A new car means saving less.* / *I meant to call you.*"),
                R("go on", "continue with the same thing", "change to something new", "*She went on talking for hours.* / *After the intro he went on to describe the method.*"),
                R("like / love", "enjoy (general taste)", "think it right; choose to (habit)", "*I love swimming at night.* / *I like to check the mirrors before setting off.*")
            )
        ),
        new LearnSection(
            "Bare infinitive: make, let, help and the perception verbs",
            new Table(
                ["Structure", "Rule", "Example"],
                R("make sb do", "no *to*; passive adds *to*", "*They made me wait outside.* → *I was made **to wait** outside.*"),
                R("let sb do", "no *to*, ever; no passive", "*Let me explain.* — *~~let me to explain~~*; instead of a passive say *be allowed to*"),
                R("allow sb to do", "= let, but takes *to* and has a passive", "*We were allowed to leave early.*"),
                R("help (sb) (to) do", "both forms correct", "*She helped me (to) fill in the form.*"),
                R("see / watch / hear / feel sb do", "whole completed action", "*I saw him cross the street.* (from one side to the other)"),
                R("see / watch / hear sb doing", "action in progress", "*I saw him crossing the street.* (halfway over)"),
                R("would rather do", "no *to*", "*I'd rather stay at home tonight.*"),
                R("had better do", "no *to*; negative: *had better not*", "*You'd better hurry. You'd better not be late.*"),
                R("why not do? / why do…?", "no *to*", "*Why not wait here? Why pay more?*")
            )
        ),
        new LearnSection(
            "Preposition + -ing (learn the whole chain)",
            new Table(
                ["Expression", "Example"],
                R("accuse sb **of**", "*They accused her of leaking the story.*"),
                R("apologise **for**", "*He apologised for keeping us waiting.*"),
                R("believe **in**", "*Do you believe in working from home?*"),
                R("blame sb **for**", "*Don't blame me for the mix-up.*"),
                R("complain **about**", "*She complained about being overcharged.*"),
                R("concentrate **on**", "*Concentrate on finishing, not on winning.*"),
                R("congratulate sb **on**", "*I congratulated them on passing first time.*"),
                R("cope / deal **with**", "*How do you cope with working nights?*"),
                R("depend / rely **on**", "*You can't rely on getting a seat.*"),
                R("discourage / prevent sb **from**", "*Nothing prevented him from trying again.*"),
                R("dream **of / about**", "*She dreams of opening a bakery.*"),
                R("excuse / forgive sb **for**", "*Forgive me for asking.*"),
                R("insist **on**", "*He insisted on carrying my suitcase.*"),
                R("be interested **in**", "*I'm interested in learning Korean.*"),
                R("object **to**", "*I object to being kept waiting.*"),
                R("look forward **to**", "*I look forward to hearing from you.*"),
                R("be / get used **to**", "*I'm not used to driving on the left.*"),
                R("be good / brilliant **at**", "*He's good at fixing things.*"),
                R("be keen **on**", "*She's keen on paddleboarding.*"),
                R("be capable **of**", "*He's capable of passing with top marks.*"),
                R("be tired **of**", "*I'm tired of explaining it.*"),
                R("be afraid / frightened **of**", "*She's afraid of flying.*"),
                R("succeed **in**", "*They succeeded in persuading the council.*"),
                R("suspect sb **of**", "*They suspected him of forging the signature.*"),
                R("take part / participate **in**", "*All students took part in designing the survey.*"),
                R("thank sb **for**", "*I thanked her for helping with the move.*"),
                R("think **of / about**", "*What do you think of the plan? He's thinking of retiring early.*"),
                R("warn sb **against**", "*Doctors warned him against lifting anything heavy.*"),
                R("instead **of** / in addition **to**", "*Instead of complaining, write to them. In addition to paying rent, we pay bills.*")
            )
        ),
        new LearnSection(
            "Fixed -ing expressions worth collecting",
            new Bullets(
                "*it's no use crying; it's (not) worth asking; there's no point (in) arguing; it goes without saying*",
                "*have difficulty / trouble (in) finding; be busy revising; spend / waste hours commuting*",
                "*what about / how about ordering in? can't face cooking; can't help smiling*",
                "Trap: *suggest* and *insist* never take an object before the verb — *~~She suggested us to leave.~~* Say *She suggested **that we** leave / She suggested **leaving**.*"
            )
        )
    );

    // ------------------------------------------------------------------ modals

    private static readonly LearnLibrary.Topic Modals = new(
        "modals", "Modals", "Every function C1 tests — deduction, obligation, prohibition, advice, criticism — in present and past forms.", "Grammar",
        new LearnSection(
            "Functions at a glance",
            new Table(
                ["Function", "Present", "Past", "Example"],
                R("certainty it IS true (deduction)", "must be / must do", "must have done", "*He must be stuck in traffic. She must have forgotten.*"),
                R("certainty it ISN'T true", "can't be / can't do", "can't / couldn't have done", "*That can't be Sue — she's in Berlin. They can't have got lost.*"),
                R("possibility", "may / might / could be", "may / might / could have done", "*He might have taken the 6 a.m. train.*"),
                R("obligation from the speaker", "must", "— (use *had to*)", "*I must finish this today.*"),
                R("obligation from outside rules", "have to / has to", "had to", "*Visitors have to sign in. We had to queue.*"),
                R("prohibition", "mustn't", "wasn't allowed to / couldn't", "*You mustn't touch that. As kids we weren't allowed to stay out late.*"),
                R("no obligation", "needn't / don't have to", "didn't have to", "*You needn't dress up. I didn't have to pay.*"),
                R("advice", "should / ought to / had better", "should have done", "*You should book early. You should have booked.*"),
                R("criticism / regret about the past", "—", "should have / could have / needn't have", "*You could have warned me! She needn't have panicked.*"),
                R("permission", "can / could / may", "was allowed to", "*May I leave early? We were allowed to go.*"),
                R("ability — general", "can / am able to", "could", "*I could read at four.*"),
                R("ability — one specific success", "can / manage to", "was able to / managed to", "*The fire spread, but everyone was able to escape.*"),
                R("requests", "will / can / could / would", "—", "*Could you pass the salt? Would you mind waiting?*"),
                R("offers and suggestions", "shall I / we, I'll, we could", "—", "*Shall I carry that? We could meet at six.*")
            )
        ),
        new LearnSection(
            "must vs have to",
            new Table(
                ["", "must", "have to"],
                R("source of the obligation", "the speaker feels or imposes it", "external rules, laws, other people"),
                R("example", "*I must stop biting my nails.* / *You must come to dinner.*", "*You have to wear a helmet. Nurses have to work weekends.*"),
                R("negative — crucial difference", "*mustn't* = forbidden: *You mustn't smoke here.*", "*don't have to* = optional: *You don't have to smoke outside.*"),
                R("past", "no past — borrow *had to*", "*had to*")
            )
        ),
        new LearnSection(
            "needn't have vs didn't need to",
            new Table(
                ["Form", "Meaning", "Example"],
                R("needn't have done", "did it — but it turned out unnecessary", "*You needn't have brought wine! We've got plenty.* (you did bring it)"),
                R("didn't need to do / didn't have to do", "it wasn't necessary — and probably didn't do it", "*I didn't need to get up early, so I slept in.*"),
                R("—", "possible but ambiguous: maybe it was done", "*She didn't need to cook, but she did anyway.*")
            ),
            new Note("Classic Part 4 bait: *It wasn't necessary for her to call, and she didn't.* → *She **didn't need to call / didn't have to call**.* Only *needn't have called* would mean she DID call.")
        ),
        new LearnSection(
            "Ability: can, could, be able to",
            new Table(
                ["Form", "Use", "Example"],
                R("can", "general ability now", "*I can swim.*"),
                R("could", "general ability in the past", "*I could swim at five.*"),
                R("was able to / managed to / succeeded in -ing", "one specific achievement in the past", "*We managed to escape the fire.* — not *~~could escape~~*"),
                R("could have done", "an unrealised past possibility", "*You could have been killed!*"),
                R("be able to", "fills the gaps *can* can't cover: future, perfect, infinitive", "*You'll be able to walk again. I'd love to be able to dance. He has never been able to whistle.*")
            )
        ),
        new LearnSection(
            "Looking back: should have, could have, would have",
            new Table(
                ["Form", "Meaning", "Example"],
                R("should have done", "the right thing — but it didn't happen", "*You should have told me earlier.*"),
                R("ought to have done", "same as *should have*", "*I ought to have thanked them.*"),
                R("could have done", "a missed possibility", "*We could have won.*"),
                R("would have done", "the intention/result blocked by something", "*I would have come, but the trains stopped.*"),
                R("needn't have done", "did it, but it was unnecessary", "*She needn't have worried — everyone passed.*")
            )
        ),
        new LearnSection(
            "Typical exam traps",
            new DoDont(
                ["*You mustn't tell anyone.* (forbidden)", "*She must have missed the bus.* (sure she did)", "*He was able to finish on time.* (one occasion)"],
                ["*~~You needn't tell anyone~~* if you mean FORBIDDEN", "*~~She mustn't have missed the bus.~~* (use *can't have*)", "*~~He could finish on time that day.~~* (use *was able to / managed to*)"])
        )
    );

    // ------------------------------------------------------------------ reported speech

    private static readonly LearnLibrary.Topic ReportedSpeech = new(
        "reported-speech", "Reported speech", "Full backshift table, every time and place change, questions and commands, and 25+ reporting verbs with their patterns.", "Grammar",
        new LearnSection(
            "Backshift: every tense",
            new Table(
                ["Direct", "Reported", "Example"],
                R("present simple", "past simple", "*'I work from home.'* → *She said she worked from home.*"),
                R("present continuous", "past continuous", "*'We're moving.'* → *They said they were moving.*"),
                R("present perfect", "past perfect", "*'I've lost the keys.'* → *He said he had lost the keys.*"),
                R("past simple", "past perfect", "*'I missed the bus.'* → *She said she had missed the bus.*"),
                R("past continuous", "past perfect continuous (or unchanged)", "*'I was sleeping.'* → *He said he had been sleeping.*"),
                R("past perfect", "no change", "*'I had forgotten.'* → *She said she had forgotten.*"),
                R("will", "would", "*'I'll help.'* → *He said he would help.*"),
                R("can", "could", "*'I can drive.'* → *She said she could drive.*"),
                R("may", "might", "*'I may be late.'* → *He said he might be late.*"),
                R("must (obligation)", "had to (or *must* if still valid)", "*'I must go.'* → *She said she had to go.*"),
                R("shall", "would (offers: *should*)", "*'I shall return.'* → *He said he would return.*"),
                R("would / could / might / should / ought to", "no change", "*'I could come.'* → *She said she could come.*"),
                R("used to / had better", "no change", "*'You'd better wait.'* → *He said I'd better wait.*")
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
                R("the day after tomorrow", "in two days' time"),
                R("the day before yesterday", "two days before / earlier"),
                R("last week / month", "the week / month before; the previous week"),
                R("next week / Monday", "the following week; the next Monday"),
                R("ago", "before / earlier"),
                R("this morning", "that morning"),
                R("here", "there"),
                R("this / these", "that / those"),
                R("come", "go"),
                R("bring", "take")
            ),
            new Note("No backshift when the situation is still true or the reporting verb is present tense: *She says she **is** tired. / He said he **lives** in Rome.* (still true)")
        ),
        new LearnSection(
            "Questions and commands",
            new Table(
                ["Type", "Rule", "Example"],
                R("yes/no question", "*if / whether* + statement word order", "*'Are you coming?'* → *She asked **if I was coming**.* — not *~~asked if was I coming~~*"),
                R("wh- question", "keep the question word + statement order", "*'Where do you live?'* → *He asked **where I lived**.*"),
                R("positive command / request", "*tell / order / ask* + obj + to-inf", "*'Sit down.'* → *The officer **told us to sit down**.*"),
                R("negative command", "*tell* + obj + **not to** do", "*'Don't touch it.'* → *She **told me not to touch** it.*")
            )
        ),
        new LearnSection(
            "Reporting verbs and the pattern each takes",
            new Table(
                ["Verb", "Pattern", "Example"],
                R("admit", "+ -ing / that", "*He admitted breaking it. He admitted that he had broken it.*"),
                R("advise", "+ obj + to-inf / + -ing (general)", "*I advised her to wait. She advised taking the early train.*"),
                R("agree", "+ to-inf / that", "*They agreed to lower the price.*"),
                R("announce", "+ that", "*The airline announced that flights were delayed.*"),
                R("apologise", "+ for + -ing", "*He apologised for shouting.*"),
                R("blame", "+ sb + for / + sth + on sb", "*She blamed me for the delay. She blamed the delay on me.*"),
                R("claim", "+ to-inf / that", "*He claims to have met the president.*"),
                R("complain", "+ about / that", "*Guests complained about the noise.*"),
                R("congratulate", "+ sb + on + -ing", "*I congratulated her on winning.*"),
                R("convince / reassure", "+ sb + that", "*They convinced me that the plan was safe.*"),
                R("decide", "+ to-inf", "*We decided to postpone it.*"),
                R("deny", "+ -ing", "*She denied leaking the memo.*"),
                R("encourage", "+ sb + to-inf", "*The coach encouraged them to attack.*"),
                R("explain", "+ sth + to sb (never ~~explain sb sth~~)", "*She explained the rule to me.*"),
                R("insist", "+ on + -ing / that", "*He insisted on paying. He insisted that it was an accident.*"),
                R("invite", "+ sb + to-inf", "*They invited us to stay for the weekend.*"),
                R("offer", "+ to-inf", "*He offered to carry my bag.*"),
                R("order", "+ sb + to-inf", "*The judge ordered him to pay costs.*"),
                R("persuade", "+ sb + to-inf", "*I persuaded her to stay.*"),
                R("promise", "+ to-inf / that", "*I promised to be on time.*"),
                R("remind", "+ sb + to-inf / that", "*She reminded me to lock up. She reminded me that I had a dental appointment.*"),
                R("recommend", "+ -ing / that", "*I recommend booking early.*"),
                R("refuse", "+ to-inf", "*He refused to answer.*"),
                R("regret", "+ -ing / to say", "*I regret selling it. We regret to inform you…*"),
                R("say", "+ (that) / say to sb", "*She said (that) she was ill. She said to me…* — never *~~said me~~*"),
                R("suggest", "+ -ing / that", "*He suggested trying again. He suggested that we try again.*"),
                R("tell", "+ sb + (that) / + sb + to-inf", "*She told me the truth. She told me to go.*"),
                R("threaten", "+ to-inf", "*They threatened to strike.*"),
                R("warn", "+ sb about sth / + sb not to do / + against -ing", "*They warned us about the ice. She warned me not to sign. He warned us against buying it.*")
            )
        ),
        new LearnSection(
            "Typical exam traps",
            new DoDont(
                ["*He asked where the station was.*", "*She told me she would call.*", "*They invited us to join them.*"],
                ["*~~He asked where was the station.~~*", "*~~She said me she would call.~~*", "*~~They suggested us to join them.~~*"])
        )
    );

    // ------------------------------------------------------------------ quantifiers

    private static readonly LearnLibrary.Topic Quantifiers = new(
        "quantifiers", "Quantifiers", "much or many, each or every, all or whole — with the uncountable nouns that trip people up.", "Grammar",
        new LearnSection(
            "Countable vs uncountable: the decision table",
            new Table(
                ["Quantity", "Countable", "Uncountable", "Example"],
                R("large amount", "many, a large number of, several", "much, a great deal of, a large amount of", "*many trains; much of the city was flooded*"),
                R("'some' — positive", "a few", "a little", "*a few chairs; a little help*"),
                R("'hardly any' — negative", "(very) few", "(very) little", "*few options; little hope*"),
                R("comparative", "fewer", "less", "*fewer cars; less traffic*"),
                R("question", "how many…?", "how much…?", "*How many people? How much money?*"),
                R("either type", "a lot of / lots of / plenty of / hardly any", "a lot of / lots of / plenty of / hardly any", "*plenty of seats; plenty of time; hardly any mistakes / hardly any money*"),
                R("comparative, both types", "more", "more", "*more friends; more time*")
            ),
            new Note("*less* is creeping into countable use (*10 items or less*), but exams still want *fewer* + plural countable: *fewer cars, less traffic*.")
        ),
        new LearnSection(
            "Uncountable nouns that look countable",
            new Table(
                ["Noun (uncountable)", "How to count it"],
                R("advice", "*a piece of advice, some advice* — never *~~advices~~*"),
                R("information", "*a piece / bit of information*"),
                R("news", "*a piece of good news; the news is on at nine*"),
                R("furniture", "*a piece of furniture; much furniture*"),
                R("luggage", "*an item / piece of luggage*"),
                R("equipment", "*a piece of equipment*"),
                R("progress", "*make progress; some progress* — *~~a progress~~*"),
                R("research", "*a piece of research; a study*"),
                R("money", "*a sum / an amount of money*"),
                R("homework / housework", "*do homework / some housework; two pieces of homework*"),
                R("knowledge", "*a knowledge of French* (exception — *a* is possible)"),
                R("work", "*a piece of work; a job* (a work = a work of art)"),
                R("bread", "*a loaf / slice of bread*"),
                R("paper", "*a sheet of paper* (paper = material; *a paper* = a newspaper / essay)")
            )
        ),
        new LearnSection(
            "each vs every",
            new Table(
                ["Feature", "each", "every"],
                R("minimum number", "two or more", "three or more"),
                R("viewpoint", "one by one, individually", "all together, as a group"),
                R("with of", "*each of the twins / each of them*", "*every one of them* (not *~~every of them~~*)"),
                R("with almost / nearly", "no — *~~almost each~~*", "*almost every seat*"),
                R("special patterns", "*each + singular verb*", "*every four years; every other day; every single time*"),
                R("pronoun forms", "*each has a key*", "*everyone / everybody* (+ singular verb)")
            )
        ),
        new LearnSection(
            "all vs whole",
            new Bullets(
                "**all** + the / my / these + noun: *all the students, all my life, all these questions*.",
                "**the whole** + noun: *the whole class, the whole trip, the whole truth*.",
                "*all day = the whole day*; with place names use *the whole of*: *the whole of Madrid*.",
                "With plurals *whole* is rare: *all the students*, not *~~the whole students~~*.",
                "Before pronouns: *all of us / all of it* — or *we all, it all*."
            )
        ),
        new LearnSection(
            "none, no, neither, either, both",
            new Table(
                ["Word", "Grammar", "Example"],
                R("no", "no + noun (noun then needs no article)", "*no tickets left; no time*"),
                R("none of", "none of + the / my / us / them; verb singular (formal) or plural (informal)", "*None of them **was/were** late.*"),
                R("none", "standalone answer", "*How many were left? — None.*"),
                R("neither of", "neither of + the / us / them + singular verb", "*Neither of them **knows**.*"),
                R("neither… nor", "verb agrees with the nearer subject", "*Neither the manager nor the staff **were** told.*"),
                R("either… or / either", "one or the other", "*You can park on either side. Either day suits me.*"),
                R("both of / both…and", "verb plural", "*Both of the windows are open. Both Ana and Paco came.*"),
                R("not…either", "negative partner of *both*", "*I don't like it either.*"),
                R("short replies", "*So do I / Neither do I*", "*'I love jazz.' — 'So do I.' / 'Neither do I.'*")
            )
        ),
        new LearnSection(
            "Amount words worth collecting",
            new Table(
                ["Expression", "Meaning", "Example"],
                R("hardly any", "almost none", "*Hardly any students failed.*"),
                R("hardly ever", "almost never", "*We hardly ever eat out.*"),
                R("plenty of", "more than enough (both types)", "*plenty of chairs; plenty of time*"),
                R("most (of the)", "the majority — *most people* general, *most of the people* a specific group", "*Most Spaniards holiday in August. Most of the class passed.*"),
                R("the majority of", "formal *most of*", "*The majority of voters said no.*"),
                R("a couple of", "two, informally 'a few'", "*a couple of minutes*"),
                R("a handful of", "a very small number", "*a handful of protesters*"),
                R("dozens of / loads of (informal)", "very many", "*loads of photos*"),
                R("a great deal of", "formal 'much'", "*a great deal of patience*"),
                R("a wide range of / a large proportion of", "formal quantity", "*a wide range of courses*")
            )
        ),
        new LearnSection(
            "Typical exam traps",
            new DoDont(
                ["*fewer cars, less traffic*", "*most people agree*", "*every one of them passed*", "*all the students*"],
                ["*~~less cars~~*", "*~~most of people agree~~*", "*~~every of them passed~~*", "*~~the all students~~*"])
        )
    );

    // ------------------------------------------------------------------ relative clauses

    private static readonly LearnLibrary.Topic RelativeClauses = new(
        "relative-clauses", "Relative clauses", "Defining vs non-defining, every pronoun including what, participle reductions and preposition placement.", "Grammar",
        new LearnSection(
            "Defining vs non-defining",
            new Table(
                ["Feature", "Defining", "Non-defining"],
                R("Purpose", "identifies which one", "extra information about a known noun"),
                R("Punctuation", "no commas", "commas around the clause"),
                R("*that*", "possible", "impossible — use *which* or *who*"),
                R("Omitting the pronoun", "object pronouns only", "impossible"),
                R("Spoken stress", "clause stressed", "clause said as an aside"),
                R("Example", "*The woman **who lives** next door is a vet.*", "*My boss, **who studied** in Rome, speaks Italian.*")
            ),
            new Note("With one-of-a-kind nouns (my brother, Madrid, the Eiffel Tower) the clause is always non-defining: *My brother, who lives in Rome, is visiting.* — no commas would suggest I have several brothers.")
        ),
        new LearnSection(
            "The pronouns",
            new Table(
                ["Pronoun", "Refers to", "Example"],
                R("who", "people, as subject", "*the man **who** called you*"),
                R("whom", "people, as object — formal, or after a preposition", "*the client **whom** we invited; the partner with **whom** I work*"),
                R("which", "things", "*the book **which** won the prize*"),
                R("that", "people or things — defining clauses only", "*the keys **that** are on the table*"),
                R("whose", "possession — people or things", "*the author **whose** book I reviewed; a house **whose** roof leaks*"),
                R("where", "places", "*the café **where** we first met*"),
                R("when", "times", "*the summer **when** everything changed*"),
                R("why", "reasons — after *the reason*", "*the reason **why** she resigned* (or *the reason she resigned*)")
            )
        ),
        new LearnSection(
            "what, whatever, whoever",
            new Table(
                ["Word", "Meaning", "Example"],
                R("what", "= the thing(s) that — never follows a noun", "*What he said surprised me. What I need is a holiday.*"),
                R("—", "after a noun use *that/which*: *~~the film what won~~*", "*the film that won*"),
                R("whatever", "anything that", "*Take whatever you need.*"),
                R("whoever", "the person who / anyone who", "*We'll give the prize to whoever arrives first.*"),
                R("whichever", "any one from a known set", "*Pick whichever flavour you like.*"),
                R("wherever / whenever", "any place / any time", "*Sit wherever you like. Call me whenever you land.*")
            )
        ),
        new LearnSection(
            "Omitting the pronoun",
            new Para("Only a **defining** clause with an **object** pronoun can lose it: *The film **(that)** we saw…*, *The man **(who)** I met…*. Subject pronouns and all non-defining clauses must keep their pronoun: *The film **that won** the prize…* (no omission).")
        ),
        new LearnSection(
            "Prepositions in relative clauses",
            new Table(
                ["Formal", "Informal"],
                R("the colleague **with whom** I share an office", "the colleague **(who/that) I share an office with**"),
                R("the house **in which** I grew up", "the house **(that) I grew up in**"),
                R("a topic **about which** little is known", "a topic **(which) little is known about**"),
                R("the partner **to whom** it was sold", "the partner **(who) it was sold to**")
            ),
            new Note("Never put a preposition directly before *that*: *~~with that I work~~*. And after a preposition *that* is impossible even informally: *~~the house in that I grew up~~*.")
        ),
        new LearnSection(
            "Making clauses shorter: participles and infinitives",
            new Table(
                ["Full clause", "Shortened"],
                R("*The man **who is sitting** by the door is my uncle.*", "*The man **sitting** by the door is my uncle.*"),
                R("*The paintings **which were stolen** were recovered.*", "*The paintings **stolen** were recovered.*"),
                R("*Anyone **who wishes** to apply should write in.*", "*Anyone **wishing** to apply should write in.*"),
                R("*She was the first woman **who climbed** it alone.*", "*She was the first woman **to climb** it alone.* (after *first / last / next / only*)"),
                R("*He was the only guest **who complained**.*", "*He was the only guest **to complain**.*")
            )
        ),
        new LearnSection(
            "Quantifier + of whom / of which",
            new Bullets(
                "*three cousins, **two of whom** live abroad*",
                "*a list of tasks, **all of which** are overdue*",
                "*several bridges, **the oldest of which** dates from 1780*",
                "*which* can also refer to a whole sentence: *He arrived an hour late, **which** annoyed everyone.*"
            )
        ),
        new LearnSection(
            "Typical exam traps",
            new DoDont(
                ["*My brother, who lives in Rome, is visiting.*", "*The man that lives upstairs is quiet.*", "*a car whose engine leaks oil*"],
                ["*~~My brother who lives in Rome is visiting.~~* (implies several brothers)", "*~~The film what I saw~~*", "*~~the car which its engine…~~*"])
        )
    );

    // ------------------------------------------------------------------ inversion

    private static readonly LearnLibrary.Topic Inversion = new(
        "inversion", "Inversion", "Twenty-plus triggers with structures and examples: negative adverbials, conditionals, so/such and echo replies.", "Grammar",
        new LearnSection(
            "How it works",
            new Para("Front the negative or limiting adverbial, then use **question word order**. With simple tenses that means *do/does/did*; with *be*, *have* and modals, invert directly: *Rarely **does he** complain. Never **have I** seen such a mess. Never **was** there any doubt.*")
        ),
        new LearnSection(
            "The trigger table",
            new Table(
                ["Trigger", "Structure", "Example"],
                R("Never (before / again)", "aux + subject", "**Never have I** seen such a mess."),
                R("Rarely / Seldom", "do-aux or direct inversion", "**Rarely does he** complain about the hours."),
                R("Little (…know / realise)", "aux + subject", "**Little did she** know what was waiting."),
                R("Nowhere / Nowhere else", "modal or aux + subject", "**Nowhere else can you** find this species."),
                R("Not only … (but … also)", "do-aux or aux", "**Not only did she win,** but she also broke the record."),
                R("No sooner … than", "past perfect, then *than* + past simple", "**No sooner had we left than** it started to rain."),
                R("Hardly / Scarcely … when", "past perfect, then *when* + past simple", "**Hardly had I sat down when** the phone rang."),
                R("Under no circumstances", "modal + subject", "**Under no circumstances should you** open that door."),
                R("On no account", "modal + subject", "**On no account must** this door be left unlocked."),
                R("At no time / At no point", "do-aux or aux", "**At no time did** the crew panic."),
                R("In no way / In no sense", "do-aux or aux", "**In no way does** this excuse their behaviour."),
                R("Not once / Not for a moment", "do-aux or aux", "**Not once did she** look at me."),
                R("Only then / Only later", "do-aux or aux", "**Only then did I** realise my mistake."),
                R("Only when / by / after + clause", "inversion in the MAIN clause", "**Only when she left did** I notice the letter."),
                R("Not until + time / clause", "inversion in the MAIN clause", "**Not until the next morning did** we hear the news."),
                R("Not since + time", "aux + subject", "**Not since 2010 have** prices risen so fast."),
                R("So + adjective / adverb", "*so + adj + be/aux + subject + that*", "**So absurd was** his excuse that nobody laughed."),
                R("Such + (a/an) + noun", "*such + be + subject + that*", "**Such was** the demand that tickets sold out in minutes."),
                R("Should (conditional)", "*Should + subject + base*", "**Should you need help,** call me."),
                R("Were (conditional)", "*Were + subject*", "**Were I** in your position, I would refuse."),
                R("Had (conditional)", "*Had + subject + V3*", "**Had I known,** I would have called."),
                R("Come what may", "fixed formula — no auxiliary", "**Come what may,** we'll meet at six.")
            ),
            new Note("With *No sooner…than* and *Hardly…when* the perfect goes in the inverted clause and the *past simple* in the other: *No sooner **had** we left **than** it started* — never *~~No sooner had we left when…~~*")
        ),
        new LearnSection(
            "Conditional inversion, paired up",
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
            "Echo replies: so and neither",
            new Table(
                ["Statement", "Agreeing", "Disagreeing"],
                R("*I like jazz.* (present simple)", "**So do I.**", "**I don't.**"),
                R("*I'm tired.* (be)", "**So am I.**", "**I'm not.**"),
                R("*I can swim.* (modal)", "**So can I.**", "**I can't.**"),
                R("*I've finished.* (perfect)", "**So have I.**", "**I haven't.**"),
                R("*I went by train.* (past simple)", "**So did I.**", "**I didn't.**"),
                R("*I'd love one.* (would)", "**So would I.**", "**I wouldn't.**"),
                R("*I don't eat meat.* (negative statement)", "**Neither do I. / Nor do I.**", "**I do.**")
            )
        ),
        new LearnSection(
            "Typical exam traps",
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
