using static PracticingCAE.Web.Components.Pages.LearnContent.LearnBlock;
using static PracticingCAE.Web.Components.Pages.LearnContent.LearnText;

namespace PracticingCAE.Web.Components.Pages.LearnContent;

/// <summary>Vocabulary and usage cheat sheets, in canonical order.</summary>
public static class VocabularyTopics
{
    // ------------------------------------------------------------------ prepositions

    private static readonly LearnLibrary.Topic Prepositions = new(
        "prepositions", "Dependent prepositions", "Verb, adjective and noun + preposition: 90+ high-frequency combinations, each with an example.", "Vocabulary and usage",
        new LearnSection(
            "Verb + preposition",
            new Table(
                ["Verb + preposition", "Example"],
                R("accuse sb **of**", "*They accused her of leaking the story.*"),
                R("agree **with** sb / **on** a plan / **to** a proposal", "*I agree with you, but we can't agree on a date.*"),
                R("apologise **to** sb **for** sth", "*He apologised to the passengers for the delay.*"),
                R("apply **to** (organisation) **for** (job)", "*She applied to three firms for an internship.*"),
                R("approve **of**", "*My parents don't approve of my flatmate.*"),
                R("argue **with** sb **about** sth", "*They're always arguing about money.*"),
                R("arrive **at** (place) / **in** (city)", "*We arrived at the hotel at midnight. We arrived in Oslo on Tuesday.*"),
                R("ask sb **for**", "*Can I ask you for a favour?*"),
                R("ban sb **from** -ing", "*He was banned from driving for a year.*"),
                R("base sth **on**", "*The series is based on real events.*"),
                R("believe **in**", "*Do you believe in life on other planets?*"),
                R("blame sb **for** sth / blame sth **on** sb", "*They blamed the crash on the driver. They blamed the driver for the crash.*"),
                R("borrow sth **from** sb", "*I borrowed a bike from my cousin.*"),
                R("complain **to** sb **about** sth", "*She complained to the manager about the noise.*"),
                R("concentrate **on**", "*Concentrate on the ending, not the details.*"),
                R("congratulate sb **on**", "*I congratulated them on their engagement.*"),
                R("consist **of**", "*The panel consists of five judges.*"),
                R("cope **with** / deal **with**", "*The airline coped with the strike. The receptionist dealt with the complaint.*"),
                R("decide **on**", "*We've finally decided on a name.*"),
                R("depend / rely **on**", "*The trip depends on the weather. You can rely on Pedro.*"),
                R("die **of / from**", "*He died of a heart attack.*"),
                R("differ **from**", "*British English differs from American English in spelling.*"),
                R("discourage sb **from** -ing", "*High prices discourage people from using the car.*"),
                R("divide **into**", "*The class was divided into pairs.*"),
                R("dream **of / about**", "*She dreams of opening a bakery.*"),
                R("explain sth **to** sb", "*Can you explain the rules to me?* — never *~~explain me~~*"),
                R("forgive sb **for**", "*Forgive me for asking, but…*"),
                R("head **for / towards**", "*We headed for the coast.*"),
                R("hear **from** sb / **about** sth", "*I haven't heard from her since June.*"),
                R("hope **for**", "*We're hoping for good news.*"),
                R("insist **on**", "*He insisted on carrying my suitcase.*"),
                R("laugh **at**", "*It's rude to laugh at people.*"),
                R("lend sth **to** sb", "*Lend your notes to Marta.* (= lend Marta your notes)"),
                R("listen **to**", "*Listen to your body.*"),
                R("look **at** / **for** / **after**", "*Who looks after the garden? I'm looking for my keys.*"),
                R("object **to**", "*I object to paying twice.*"),
                R("pay **for**", "*Who's paying for the tickets?*"),
                R("prefer sth **to** sth", "*I prefer tea to coffee.*"),
                R("prevent sb **from** -ing", "*The fence prevents dogs from getting in.*"),
                R("provide sb **with** sth", "*The camp provides guests with towels.*"),
                R("punish sb **for**", "*He was punished for cheating.*"),
                R("react **to**", "*Markets reacted badly to the news.*"),
                R("recover **from**", "*She's recovering from flu.*"),
                R("remind sb **of** sb / **about** sth", "*You remind me of my brother. Remind me about the meeting.*"),
                R("search **for**", "*Police are searching for the driver.*"),
                R("shout **at** (angry) / **to** (so as to be heard)", "*Don't shout at the referee. She shouted to us from the window.*"),
                R("spend (money) **on**", "*I spent €60 on books.*"),
                R("steal sth **from** sb", "*Someone stole a painting from the gallery.*"),
                R("suffer **from**", "*Millions suffer from insomnia.*"),
                R("suspect sb **of**", "*They suspected him of forging the signature.*"),
                R("take part **in** / participate **in**", "*All students took part in the survey.*"),
                R("thank sb **for**", "*I thanked her for her patience.*"),
                R("think **of / about**", "*What do you think of the plan? I'm thinking about changing jobs.*"),
                R("throw sth **at** (to hit) / **to** (to catch)", "*He threw the ball to me, not at me!*"),
                R("translate **from** … **into**", "*Translate the phrase from German into English.*"),
                R("vote **for / against**", "*I voted for the proposal.*"),
                R("wait **for**", "*We waited for the rain to stop.*"),
                R("warn sb **about / of** / **against** -ing", "*They warned us about the currents / against swimming there.*"),
                R("write **to**", "*Write to me when you arrive.*")
            )
        ),
        new LearnSection(
            "Adjective + preposition",
            new Table(
                ["Adjective + preposition", "Example"],
                R("absent **from**", "*He was absent from class twice.*"),
                R("accustomed **to**", "*She's accustomed to hard work.*"),
                R("addicted **to**", "*He's addicted to energy drinks.*"),
                R("afraid / frightened **of**", "*The dog is afraid of thunder.*"),
                R("amazed / surprised **at / by**", "*I was amazed at her memory.*"),
                R("angry **about** sth / **with** sb", "*I was angry about the bill and furious with the waiter.*"),
                R("anxious / worried **about**", "*He's anxious about the interview.*"),
                R("ashamed **of**", "*You should be ashamed of yourself.*"),
                R("aware / conscious **of**", "*Are you aware of the risks?*"),
                R("bad / hopeless **at**", "*I'm hopeless at reading maps.*"),
                R("bored **with**", "*The kids got bored with the tour.*"),
                R("brilliant / good **at**", "*She's brilliant at chess.*"),
                R("busy **with**", "*I'm busy with paperwork.*"),
                R("capable **of**", "*He's capable of great kindness.*"),
                R("certain **of**", "*Are you certain of the date?*"),
                R("close **to**", "*I've always been close to my cousin.*"),
                R("crowded **with**", "*The beach was crowded with tourists.*"),
                R("curious **about**", "*I'm curious about the new neighbours.*"),
                R("delighted / pleased / satisfied **with**", "*She was delighted with the photos.*"),
                R("dependent / reliant **on**", "*We're too dependent on cars.*"),
                R("different **from**", "*The result was different from what I expected.*"),
                R("disappointed **with**", "*I was disappointed with the film.*"),
                R("eligible **for**", "*You're eligible for a discount.*"),
                R("engaged **to**", "*She's engaged to a doctor.*"),
                R("enthusiastic / serious **about**", "*They're enthusiastic about the project. Are you serious about moving?*"),
                R("experienced **in**", "*He's experienced in crisis management.*"),
                R("familiar **with** (you know it) / **to** (it is known to you)", "*I'm familiar with the software. The name is familiar to me.*"),
                R("famous **for**", "*Bologna is famous for its food.*"),
                R("fond **of**", "*I'm very fond of this city.*"),
                R("friendly **with**", "*Are you friendly with the new family?*"),
                R("full **of**", "*The report is full of errors.*"),
                R("guilty **of**", "*He was found guilty of fraud.*"),
                R("identical **to**", "*The copy is identical to the original.*"),
                R("impressed **by / with**", "*We were impressed by the design.*"),
                R("interested / involved **in**", "*I'm interested in astronomy. She's involved in local politics.*"),
                R("jealous **of**", "*He's jealous of his brother.*"),
                R("keen **on**", "*She's keen on paddleboarding.*"),
                R("kind / polite / rude **to**", "*Be kind to strangers. The staff were rude to us.*"),
                R("married **to**", "*She's married to a violinist.*"),
                R("nervous **of / about**", "*I'm nervous about flying.*"),
                R("opposed **to**", "*They're opposed to the plan.*"),
                R("patient **with**", "*Be patient with beginners.*"),
                R("popular **with**", "*The café is popular with students.*"),
                R("proud **of**", "*We're proud of the team.*"),
                R("ready **for**", "*Are you ready for the exam?*"),
                R("responsible **for**", "*Who's responsible for the delay?*"),
                R("similar **to**", "*His accent is similar to mine.*"),
                R("sorry **for** (person) / **about** (situation)", "*I'm sorry for being late. I'm sorry about the mess.*"),
                R("suspicious **of**", "*I'm suspicious of free gifts.*"),
                R("tired **of**", "*I'm tired of excuses.*"),
                R("typical **of**", "*That's typical of him.*"),
                R("upset **about**", "*She was upset about the lost ring.*"),
                R("used **to**", "*I'm used to getting up early.*")
            )
        ),
        new LearnSection(
            "Noun + preposition",
            new Table(
                ["Noun + preposition", "Example"],
                R("advantage / disadvantage **of**", "*The advantage of a bike is the price.*"),
                R("accusation **against**", "*The accusations against him were dropped.*"),
                R("addiction **to**", "*his addiction to gaming*"),
                R("attack **on**", "*an attack on the government's record*"),
                R("attitude **to / towards**", "*a relaxed attitude to deadlines*"),
                R("ban **on**", "*a ban on smoking indoors*"),
                R("cause **of** / reason **for**", "*the cause of the fire; the reason for the delay*"),
                R("congratulations **on**", "*Congratulations on the promotion!*"),
                R("contribution **to**", "*her contribution to the debate*"),
                R("damage **to**", "*damage to the engine*"),
                R("decrease / increase / rise / fall **in**", "*a sharp rise in rents*"),
                R("demand **for** / need **for**", "*demand for flats in the centre; there's no need for panic*"),
                R("difference **between**", "*the difference between the two plans*"),
                R("difficulty (in) + -ing", "*I had difficulty (in) finding tickets.*"),
                R("effect / impact / influence **on**", "*tourism's impact on the coast*"),
                R("exception **to**", "*There's an exception to every rule.*"),
                R("excuse **for**", "*a poor excuse for being late*"),
                R("expert **on / at / in**", "*an expert on Roman roads*"),
                R("insight **into**", "*The book gives an insight into village life.*"),
                R("invitation **to**", "*an invitation to the wedding*"),
                R("lack **of**", "*The project failed for lack of funds.*"),
                R("limit **on**", "*a limit on baggage*"),
                R("objection **to**", "*I have no objection to staying.*"),
                R("opinion **of**", "*What's your opinion of the manager?*"),
                R("relationship **with**", "*a good relationship with the neighbours*"),
                R("respect **for**", "*respect for other people's views*"),
                R("solution / key / answer **to**", "*a solution to the parking problem*"),
                R("success **in**", "*her success in business*"),
                R("sympathy **for**", "*sympathy for the victims*"),
                R("threat **to**", "*a threat to the wetlands*"),
                R("trouble **with**", "*The trouble with laptops is the battery.*")
            )
        ),
        new LearnSection(
            "Same root, different preposition",
            new Table(
                ["Family", "Shift", "Example"],
                R("accuse **of** → accusation **against**", "verb vs noun take different prepositions", "*They accused him of theft. The accusation against him was dropped.*"),
                R("depend **on** → dependence **on** → dependent **on**", "this family stays with *on*", "*Success depends on effort. His dependence on painkillers grew. Funding is dependent on results.*"),
                R("differ **from** → difference **between**", "verb takes *from*, noun takes *between*", "*This model differs from that one. The difference between them is price.*"),
                R("proud **of** → pride **in**", "adjective *of*, noun *in*", "*She's proud of her team. She takes pride in her work.*"),
                R("sympathetic **to** → sympathy **for**", "adjective *to*, noun *for*", "*He was sympathetic to my plan. I felt sympathy for the family.*"),
                R("angry **with** sb → anger **at** sth", "adjective *with*, noun *at*", "*They were angry with the referee. Their anger at the decision was obvious.*")
            ),
            new Examples(
                "*the key to the exercises* — *key to* is the fixed pair, same as *solution / answer to*.",
                "*succeed **in** / success **in*** — some families agree across word classes: check both halves when you learn them."
            )
        )
    );

    // ------------------------------------------------------------------ linking words

    private static readonly LearnLibrary.Topic LinkingWords = new(
        "linking-words", "Linking words", "Connectors by function with the grammar that must follow each one, its register, and the classic confusions.", "Vocabulary and usage",
        new LearnSection(
            "Contrast",
            new Table(
                ["Linker", "Followed by", "Register", "Example"],
                R("although / even though", "clause", "neutral", "**Although it rained,** we walked."),
                R("though", "clause (also sentence-final)", "informal", "She's coming, **though**."),
                R("despite / in spite of", "noun, -ing, or *the fact that* + clause", "neutral", "**Despite the rain,** we walked. **In spite of feeling tired,** she finished."),
                R("however / nevertheless / nonetheless", "new sentence", "formal", "It rained. **However,** we walked anyway."),
                R("even so", "new sentence", "neutral", "The odds were poor. **Even so,** they tried."),
                R("whereas / whilst", "clause (contrasts two facts)", "written", "I love cities, **whereas** she prefers villages."),
                R("while", "clause (contrast, not time)", "neutral", "**While** I understand your point, I disagree."),
                R("unlike + noun", "noun phrase", "neutral", "**Unlike** her brother, Ana loves crowds."),
                R("in contrast / by contrast", "new sentence", "written", "The north is wet. **In contrast,** the south is arid."),
                R("on the one hand… on the other hand", "two balanced clauses", "written", "**On the one hand** it's cheap; **on the other hand** it's far from work."),
                R("however + adjective / adverb", "adj/adv inside the clause", "formal", "**However hard** she tried, she couldn't open it.")
            ),
            new Note("One connector per contrast: *~~Although it rained, but we walked.~~* Choose *although* or *but* — never both.")
        ),
        new LearnSection(
            "Cause and reason",
            new Table(
                ["Linker", "Followed by", "Register", "Example"],
                R("because", "clause", "neutral", "We stayed in **because** it was freezing."),
                R("since / as", "clause (reason already known)", "neutral", "**As** you know, prices are rising."),
                R("because of", "noun / -ing", "neutral", "**Because of fog,** all flights were cancelled."),
                R("due to / owing to", "noun / -ing", "formal", "**Due to fog,** all flights were cancelled."),
                R("due to / owing to after *be*", "noun", "formal", "The delay **was due to** fog."),
                R("on account of", "noun", "formal", "The match was postponed **on account of** the weather."),
                R("thanks to", "noun (positive outcome)", "neutral", "**Thanks to** her quick thinking, nobody was hurt."),
                R("in view of", "noun (justifying a decision)", "formal", "**In view of** the delays, we have cancelled the route."),
                R("seeing that", "clause", "informal", "**Seeing that** it's your birthday, I'll pay.")
            )
        ),
        new LearnSection(
            "Purpose",
            new Table(
                ["Linker", "Followed by", "Register", "Example"],
                R("to / in order to / so as to", "infinitive", "neutral → formal", "I left early **to avoid** the traffic."),
                R("in order not to / so as not to", "infinitive (negative)", "formal", "I spoke quietly **so as not to** wake the baby."),
                R("so that", "clause with can / could / will / would", "neutral", "I left early **so that I could park**."),
                R("in case", "present / past clause (precaution)", "neutral", "Take a map **in case you get lost**."),
                R("in case of", "noun (warnings)", "written", "**In case of fire,** break the glass."),
                R("for + -ing", "what a thing is used for", "neutral", "A knife is **for cutting**."),
                R("with the aim of / for the purpose of", "-ing", "formal", "**With the aim of** reducing costs, the firm merged both depots.")
            )
        ),
        new LearnSection(
            "Result",
            new Table(
                ["Linker", "Followed by", "Register", "Example"],
                R("so", "clause", "neutral", "It was late, **so** we left."),
                R("therefore / consequently / as a result / as a consequence", "new sentence", "formal", "Sales fell sharply. **Consequently,** two plants closed."),
                R("hence / thus", "noun or new sentence", "formal, written", "The drug is untested; **hence** the warning."),
                R("so + adjective / adverb + that", "clause", "neutral", "It was **so hot that** we stayed indoors."),
                R("such (+ a/an) (+ adj) + noun + that", "clause", "neutral", "It was **such a boring film that** I fell asleep."),
                R("with the result that", "clause", "written", "Interest rates rose, **with the result that** mortgages became dearer.")
            ),
            new Note("Count the words in Part 4: *such a boring film* vs *so boring a film* — both are possible, but *so* needs *a* AFTER the adjective.")
        ),
        new LearnSection(
            "Addition",
            new Table(
                ["Linker", "Followed by", "Register", "Example"],
                R("moreover / furthermore", "new sentence", "formal", "The car is fast. **Moreover,** it is cheap to run."),
                R("in addition / what is more", "new sentence", "neutral", "**What is more,** the battery lasts a week."),
                R("besides", "clause", "informal", "I'm not going. **Besides,** it's too far."),
                R("as well as", "noun or -ing", "neutral", "**As well as** winning, she broke the record."),
                R("in addition to", "noun or -ing", "neutral", "**In addition to** paying rent, we cover all bills."),
                R("not only … but also", "clause — **inversion** when fronted", "neutral", "**Not only did he win,** but he also set a record."),
                R("on top of that", "new sentence", "informal", "It broke again, and **on top of that** the warranty ran out."),
                R("plus", "clause", "informal, spoken", "It's fast, **plus** it's reliable.")
            )
        ),
        new LearnSection(
            "Concession",
            new Table(
                ["Linker", "Followed by", "Register", "Example"],
                R("even if", "clause (hypothetical)", "neutral", "**Even if** it rains, we'll walk."),
                R("even though", "clause (fact)", "neutral", "**Even though** it rained, we walked."),
                R("no matter + wh- word", "clause", "neutral", "**No matter how** late it is, call me."),
                R("whether… or not", "clause", "neutral", "**Whether** you agree **or not,** the decision stands."),
                R("much as", "clause (with feelings)", "formal", "**Much as** I admire him, I disagree."),
                R("admittedly… (however)", "new sentence", "formal", "**Admittedly,** the flat is small. **However,** it's cheap."),
                R("regardless of", "noun", "neutral", "They carried on **regardless of** the warnings.")
            )
        ),
        new LearnSection(
            "The classic confusions",
            new Table(
                ["Pair", "The difference", "Examples"],
                R("although vs despite", "*although* + clause; *despite* + noun / -ing", "*Although she was tired…* / *Despite being tired…* / *Despite the traffic…*"),
                R("while vs during", "*while* + clause; *during* + noun", "*While we watched the film, it snowed.* / *During the film, it snowed.*"),
                R("as vs like", "*as* + clause or role; *like* + noun (comparison)", "*As a teacher, she…* (she is one) / *She fights like a lion.* (comparison)"),
                R("even if vs even though", "*even if* = hypothetical; *even though* = real fact", "*Even if it rains, we'll go.* (maybe rain) / *Even though it rained, we went.* (it did)"),
                R("due to vs because of", "exam-safe rule: *due to* after *be*; both + noun", "The delay **was due to** fog. **Because of** fog, we landed late."),
                R("however vs how ever", "*however* = contrast adverb; *how ever* split = surprise", "**However**, he came. / **How** ever **did** you find me?")
            )
        )
    );

    // ------------------------------------------------------------------ phrasal verbs

    private static readonly LearnLibrary.Topic PhrasalVerbs = new(
        "phrasal-verbs", "Phrasal verbs", "75+ exam-frequent phrasal verbs grouped by particle, marked separable, each with a meaning and an example.", "Vocabulary and usage",
        new LearnSection(
            "How to read the tables",
            new Note("**(S)** = separable: with a noun or pronoun object the particle can move — *turn **it** down*, *turn the music **down***. Inseparable verbs keep verb and particle together. Never separate two-word verbs like *look after*: *~~look the baby after~~*.")
        ),
        new LearnSection(
            "UP: appear, start, complete, invent",
            new Table(
                ["Phrasal verb", "Meaning", "Example"],
                R("turn up (S)", "arrive, often late or unexpectedly", "He **turned up** an hour late."),
                R("show up", "arrive, appear", "Only ten people **showed up**."),
                R("come up", "(a problem, topic) arise", "Something urgent **came up** at work."),
                R("come up with", "produce (an idea, solution)", "Who **came up with** that plan?"),
                R("bring up (S)", "raise (a child); mention a topic", "They **brought up** three kids. Don't **bring it up** again."),
                R("set up (S)", "start (a business, organisation)", "She **set up** a design studio."),
                R("take up (S)", "start (a hobby); occupy (time, space)", "I've **taken up** climbing. The sofa **takes up** half the room."),
                R("give up (S)", "stop trying; quit", "He **gave up** smoking last year. — never *~~give up it~~*: *give it up*"),
                R("end up", "finally be or do something", "We **ended up** walking home."),
                R("grow up", "become an adult", "I **grew up** in Valencia."),
                R("make up (S)", "invent (a story); reconcile", "She **made up** an excuse. They argued and then **made up**."),
                R("look up (S)", "find (a word, number) in a reference", "**Look it up** in the dictionary."),
                R("keep up with", "stay level with", "I can't **keep up with** the news cycle."),
                R("catch up with", "reach the same point as", "I need to **catch up with** my emails."),
                R("live up to", "meet (expectations)", "The film didn't **live up to** the hype."),
                R("put up with", "tolerate", "I won't **put up with** this noise."),
                R("cheer up (S)", "make or become happier", "This colour will **cheer the room up**. Cheer up!"),
                R("use up (S)", "finish a supply", "We've **used up** all the milk.")
            )
        ),
        new LearnSection(
            "DOWN and OFF: stop, cancel, refuse",
            new Table(
                ["Phrasal verb", "Meaning", "Example"],
                R("break down", "(machine) stop working; (person) lose control", "The van **broke down** on the motorway."),
                R("let sb down (S)", "disappoint", "He promised to help, then **let me down**."),
                R("turn down (S)", "refuse; lower (volume, heat)", "She **turned down** the offer. **Turn the music down.**"),
                R("calm down", "become calm", "Just **calm down** and explain."),
                R("cut down on", "reduce", "I'm **cutting down on** sugar."),
                R("put down (S)", "place; stop holding or reading", "Put the phone **down** and listen."),
                R("write down (S)", "note on paper", "**Write the number down** before you forget it."),
                R("slow down", "go more slowly", "**Slow down** — you're driving too fast."),
                R("set off", "start a journey; trigger (an alarm)", "We **set off** at dawn. The smoke **set off** the alarm."),
                R("put off (S)", "postpone; discourage", "Don't **put off** booking the dentist."),
                R("call off (S)", "cancel", "They **called off** the strike."),
                R("take off (S)", "(plane) leave the ground; remove; succeed fast", "Sales **took off** after the review. **Take your coat off.**"),
                R("let sb off (S)", "not punish", "The judge **let him off** with a warning."),
                R("drop off (S)", "fall asleep; deliver sb", "I **dropped off** during the film. I'll **drop you off** at the station."),
                R("get by", "manage (with difficulty)", "We **get by** on one salary.")
            )
        ),
        new LearnSection(
            "OUT: discover, solve, result",
            new Table(
                ["Phrasal verb", "Meaning", "Example"],
                R("find out (S)", "discover", "I **found out** the truth eventually."),
                R("work out (S)", "solve; calculate; exercise", "We'll **work out** a compromise. I **work out** twice a week."),
                R("point out (S)", "mention, draw attention to", "She **pointed out** the risks."),
                R("turn out", "prove to be; happen in the end", "It **turned out** to be a hoax."),
                R("run out of", "have no more left", "We've **run out of** milk."),
                R("carry out (S)", "perform (research, a task, a threat)", "The lab **carried out** the tests."),
                R("sort out (S)", "organise; solve", "I need to **sort out** my visa."),
                R("stand out", "be clearly noticeable", "Her essay **stood out**."),
                R("drop out (of)", "leave school or a course", "He **dropped out** of law school."),
                R("come out", "be published or released", "Her novel **comes out** in May."),
                R("leave out (S)", "omit", "You've **left out** a zero. Don't **leave me out**!"),
                R("fill out / in (S)", "complete (a form)", "**Fill the form out** in block capitals."),
                R("hand out (S)", "distribute", "They **handed out** leaflets."),
                R("make out (S)", "distinguish; claim", "I could barely **make out** the sign."),
                R("put out (S)", "extinguish", "Firefighters **put the fire out**.")
            )
        ),
        new LearnSection(
            "ON: continue, wear, accept",
            new Table(
                ["Phrasal verb", "Meaning", "Example"],
                R("hold on", "wait", "**Hold on** — I'm nearly ready."),
                R("carry on", "continue", "Carry **on** — I'm listening."),
                R("keep on -ing", "continue, often despite objections", "She **kept on asking** even after we said no."),
                R("go on", "continue; happen", "What's **going on** here?"),
                R("get on with", "have a good relationship with; continue with", "I **get on with** my colleagues. **Get on with** your homework."),
                R("get on", "progress; manage", "How are you **getting on** with the thesis?"),
                R("take on (S)", "hire; accept (work, responsibility)", "They're **taking on** staff."),
                R("put on (S)", "dress in; gain (weight)", "I've **put on** two kilos."),
                R("try on (S)", "test clothes by wearing", "**Try the jacket on** before buying.")
            )
        ),
        new LearnSection(
            "BACK, AWAY, INTO, OVER, THROUGH and friends",
            new Table(
                ["Phrasal verb", "Meaning", "Example"],
                R("give away (S)", "reveal (a secret); give free", "Don't **give away** the ending!"),
                R("throw away (S)", "discard", "Don't **throw away** the receipt."),
                R("give back (S)", "return (something borrowed)", "**Give it back** — it's mine!"),
                R("pay back (S)", "return money", "I'll **pay you back** on Friday."),
                R("take back (S)", "return (goods); retract (words)", "I'm **taking this jumper back**. I **take back** what I said."),
                R("get away with", "escape punishment for", "He **got away with** a small fine."),
                R("pass away", "die (polite)", "Her grandfather **passed away** last month."),
                R("look back on", "remember, reflect on", "I **look back on** those years fondly."),
                R("keep away from / stay away from", "avoid", "**Keep away from** the edge."),
                R("walk out (of / on)", "leave suddenly in protest; abandon", "Two directors **walked out of** the meeting."),
                R("go back on", "break (a promise, one's word)", "He never **goes back on** his word."),
                R("come across", "find by chance", "I **came across** my old diaries."),
                R("run into / bump into", "meet by chance", "I **ran into** Ana at the station."),
                R("get over", "recover from", "It took weeks to **get over** the flu."),
                R("go through", "experience; examine", "She's **going through** a hard time. Let's **go through** the contract."),
                R("look into", "investigate", "The committee will **look into** the complaint."),
                R("look after", "take care of", "Who **looks after** the dog while you're away?"),
                R("count on", "rely on", "You can **count on** Pedro."),
                R("do without", "manage without", "We'll have to **do without** a car this year."),
                R("get round to", "finally find time for", "I finally **got round to** replying."),
                R("bring about (S)", "cause, lead to", "The internet **brought about** huge changes."),
                R("put up (S)", "build; erect; give sb a bed", "They're **putting up** new flats. My aunt **put me up** for the night."),
                R("take after", "resemble (a relative)", "She **takes after** her mother."),
                R("stand for", "tolerate (in negatives); represent", "I won't **stand for** such rudeness. The **N** **stands for** north."),
                R("look forward to + -ing", "anticipate with pleasure", "I **look forward to hearing** from you.")
            )
        )
    );

    // ------------------------------------------------------------------ word formation

    private static readonly LearnLibrary.Topic WordFormation = new(
        "word-formation", "Word formation", "Prefixes, suffixes by target class, spelling rules, and the irregular pairs examiners recycle every session.", "Vocabulary and usage",
        new LearnSection(
            "Prefixes: negative and reversal",
            new Table(
                ["Prefix", "Meaning", "Examples"],
                R("un-", "not; reversal of an action", "*unhappy, unfair, unusual / undo, untie, unlock*"),
                R("in-", "not (mainly Latin roots)", "*incorrect, indirect, insensitive, incapable*"),
                R("im-", "not — before p, b, m", "*impossible, impolite, immature, imbalance*"),
                R("il-", "not — before l", "*illogical, illegal, illiterate*"),
                R("ir-", "not — before r", "*irregular, irresponsible, irrational*"),
                R("dis-", "not; opposite action", "*dishonest, disagree, disobey / disconnect, disappear*"),
                R("mis-", "wrongly", "*misunderstand, mislead, mispronounce, misuse*"),
                R("non-", "not", "*non-fiction, non-smoker, non-stop*"),
                R("de-", "reverse, remove", "*defrost, deregulate, decompose, decaffeinated*"),
                R("over-", "too much", "*overcook, overpopulated, overwork*"),
                R("under-", "too little", "*underestimate, underpaid, undercooked*"),
                R("re-", "again", "*rewrite, reconsider, reunite*"),
                R("anti-", "against", "*anti-social, anti-war, antibiotic*"),
                R("-less (suffix, not prefix)", "without — makes a new word, not the opposite", "*harmless, endless, jobless* — *priceless* means invaluable!")
            ),
            new Note("There is no rule for choosing *un-* vs *in-*: you must know the word. *unhappy* but *incorrect*; *uninterested* (don't care) vs *disinterested* (impartial).")
        ),
        new LearnSection(
            "Noun suffixes",
            new Table(
                ["Suffix", "Typical source", "Examples"],
                R("-ment", "verbs", "*argument, improvement, arrangement*"),
                R("-tion / -sion / -ation", "verbs", "*decision, education, promotion, explanation*"),
                R("-ance / -ence", "verbs, adjectives", "*performance, difference, confidence*"),
                R("-al", "verbs", "*refusal, arrival, proposal, survival*"),
                R("-ity", "adjectives", "*possibility, responsibility, curiosity*"),
                R("-ness", "adjectives", "*kindness, awareness, illness*"),
                R("-ship / -hood", "abstract relations", "*friendship, membership / childhood, motherhood*"),
                R("-age", "collectives, actions", "*marriage, baggage, storage*"),
                R("-ure / -th / -dom", "irregular classics", "*failure, pressure / warmth, depth, growth / freedom, wisdom*"),
                R("-ist / -ian / -er / -or", "people (doers)", "*artist, mathematician, trainer, actor*"),
                R("-ant / -ent", "people (agents)", "*assistant, student, participant*"),
                R("-ee", "person acted on", "*employee, trainee, interviewee*"),
                R("-ism / -cy", "systems, states", "*tourism, optimism / accuracy, privacy, frequency*")
            )
        ),
        new LearnSection(
            "Adjective suffixes",
            new Table(
                ["Suffix", "Examples"],
                R("-ful / -less", "*careful / careless, useful / useless*"),
                R("-ous", "*famous, dangerous, ambitious, courageous*"),
                R("-able / -ible", "*comfortable, dependable / visible, accessible*"),
                R("-ive", "*attractive, creative, effective, informative*"),
                R("-al", "*natural, professional, traditional, environmental*"),
                R("-ic", "*heroic, energetic, photographic*"),
                R("-ant / -ent", "*tolerant, significant / confident, different*"),
                R("-y / -ish", "*rainy, salty / childish, reddish*"),
                R("-ary / -ory", "*ordinary, necessary / explanatory, obligatory*"),
                R("-ed / -ing", "*bored / boring, thrilled / thrilling*"),
                R("-proof", "*waterproof, foolproof, bulletproof*")
            )
        ),
        new LearnSection(
            "Verb and adverb suffixes",
            new Table(
                ["Suffix", "Base → derived", "Examples"],
                R("-ise / -ize", "adjective, noun → verb", "*modernise, organise, realise, standardise*"),
                R("-ify", "adjective, noun → verb", "*simplify, clarify, justify, intensify*"),
                R("-en (adjective → verb)", "wide, deep, sharp → verbs", "*widen, deepen, sharpen, loosen, strengthen*"),
                R("-en (noun → verb)", "length, threat, strength → verbs", "*lengthen, threaten, strengthen, frighten*"),
                R("-ly (adjective → adverb)", "quick, serious → adverbs", "*quickly, seriously, remarkably*")
            ),
            new Note("Adverb traps: *public → publicly* (no *e*); *full → fully* (one *l*); *true → truly*. Adjectives ending in *-ly* (*friendly, lovely, likely*) have no adverb form — say *in a friendly way*. And *hard → hard*; *hardly* means almost not.")
        ),
        new LearnSection(
            "Spelling rules",
            new Table(
                ["Rule", "Example", "Watch out"],
                R("drop final -e before a vowel suffix", "*create → creating, argue → arguing, fame → famous*", "after soft c / g the *e* often stays: *noticeable, manageable, advantageous*"),
                R("keep -e before a consonant suffix", "*hope → hopeful, safe → safely*", "true exceptions: *argument, truly, wisdom, wholly*"),
                R("-y → -i before a suffix", "*easy → easily, heavy → heavier, rely → reliable*", "vowel + y keeps it: *enjoy → enjoying, play → playful*"),
                R("double the final consonant after a short stressed vowel", "*begin → beginning, big → biggest, refer → referred, admit → admitted*", "unstressed or long vowels don't double: *answer → answered, benefit → benefited*"),
                R("BrE doubles final -l before a vowel suffix", "*travel → travelling, model → modelling, cancel → cancellation*", "AmE often singles it: *traveling*; *full → fully* and *until* never take a third *l*"),
                R("consonant + y → -ies in plurals", "*memory → memories, company → companies*", "vowel + y just adds -s: *boys, keys*")
            ),
            new Note("BrE doubles final *l* before a vowel suffix (*travel → travelling*); AmE often doesn't (*traveling*). Pick one system and stay consistent within a paper.")
        ),
        new LearnSection(
            "Classic traps: irregular base forms",
            new Table(
                ["Base", "Derived form"],
                R("high / deep / long / strong / wide / broad", "height, depth, length, strength, width, breadth"),
                R("warm / grow / die / fly / see", "warmth, growth, death, flight, sight"),
                R("weigh / prove / believe", "weight, proof, belief"),
                R("save / lose / sell", "safety, loss, sale"),
                R("choose / succeed / know", "choice, success, knowledge"),
                R("advise / practise (BrE verb)", "ad**vice**, pra**ctice** (nouns)"),
                R("explain / maintain / destroy", "expla**nation**, mainte**nance**, destruc**tion**"),
                R("hot / proud / poor / able", "heat, pride, poverty, ability"),
                R("curious / anxious / generous", "curiosity, anxiety, generosity"),
                R("wise / young", "wisdom, youth")
            )
        ),
        new LearnSection(
            "Exam workflow",
            new DoDont(
                ["Decide the part of speech first: after *a/the* or *his* comes a noun; before a noun comes an adjective; after *very* an adjective or adverb.", "Read the whole sentence — a negative meaning often hides there: *He was ______ (ABLE) to attend* may need *unable*.", "Copy the register: *congratulations* not *congrates*; formal nouns in formal gaps."],
                ["*~~Change a letter the dictionary wouldn't: admittance where admission is standard~~*", "*~~Add a plural because the sentence has two ideas: informations~~*", "*~~Guess a suffix without checking what follows the gap~~*"])
        )
    );

    // ------------------------------------------------------------------ confusable words

    private static readonly LearnLibrary.Topic ConfusableWords = new(
        "confusable-words", "Confusable words", "35 classic pairs side by side: meaning, part of speech and one example line per pair.", "Vocabulary and usage",
        new LearnSection(
            "The big pairs table",
            new Table(
                ["Word", "Meaning", "Word", "Meaning", "Example line"],
                R("affect", "verb: influence", "effect", "noun: result", "The weather **affects** my mood — it has a calming **effect**."),
                R("advice", "noun", "advise", "verb", "Her **advice** saved the trip; she **advised** patience."),
                R("practice (BrE)", "noun", "practise (BrE)", "verb", "Football **practice** is on Monday; we **practise** in the park."),
                R("principal", "main; head of school", "principle", "rule, belief", "The **principal** reason clashes with my **principles**."),
                R("complement", "complete, go well with", "compliment", "praise", "The wine **complements** the meal — the chef took it as a **compliment**."),
                R("lose", "misplace (rhymes with *shoes*)", "loose", "not tight (rhymes with *goose*)", "Don't **lose** the key; the bolt is **loose**."),
                R("raise", "lift something else", "rise", "go up by itself", "They **raised** prices; prices **rose**."),
                R("lay", "put something down (*laid, laid*)", "lie", "recline (*lay, lain*); not tell the truth (*lied*)", "**Lay** the baby on the mat; she's **lying** down; he's **lying** about it."),
                R("remember", "recall by yourself", "remind", "make someone remember", "He **reminded** me to call — and I actually **remembered** to."),
                R("personnel", "staff", "personal", "private", "**Personal** belongings; the **personnel** department."),
                R("economic", "about the economy", "economical", "saves money", "**Economic** growth; an **economical** little car."),
                R("historic", "important in history", "historical", "about the past", "A **historic** victory; **historical** documents."),
                R("sensible", "reasonable", "sensitive", "reacts easily, feels deeply", "A **sensible** decision; **sensitive** skin."),
                R("priceless", "invaluable", "valueless / worthless", "worth nothing", "A **priceless** painting; the torn banknotes were **valueless**."),
                R("pass", "verb: go by, succeed", "past", "noun / adjective / preposition", "Time **passes**; an event from the **past**; we walked **past** the shop."),
                R("fun", "enjoyable (noun/adj)", "funny", "amusing", "The fair was great **fun**; a **funny** joke."),
                R("lend", "give temporarily", "borrow", "take temporarily", "Can you **lend** me a pen? May I **borrow** one?"),
                R("win", "a game, prize, race", "beat", "an opponent", "We **beat** them 3–0 and **won** the cup."),
                R("say", "say something (to somebody)", "tell", "tell somebody something", "She **said** nothing; she **told** me a secret."),
                R("trip", "journey + stay, countable", "journey", "the act of travelling", "A business **trip**; a four-hour **journey**."),
                R("desert", "dry land; to abandon", "dessert", "sweet course", "The Sahara **Desert**; strawberries for **dessert**."),
                R("stationary", "not moving", "stationery", "paper, pens, envelopes", "A **stationary** car; order new **stationery**."),
                R("assure", "tell confidently to remove doubt", "ensure", "make certain", "She **assured** us it was safe; lock up to **ensure** safety."),
                R("accept", "take, agree to", "except", "not including", "I **accepted** the offer; everyone **except** Tom came."),
                R("adapt", "change to fit", "adopt", "take up; take in", "**Adapt** the plan to the budget; **adopt** a puppy or a method."),
                R("beside", "next to", "besides", "in addition", "Sit **beside** me; **besides**, it's late."),
                R("quiet", "silent, calm", "quite", "fairly; completely", "A **quiet** street; **quite** cold."),
                R("weather", "climate", "whether", "if", "The **weather** changed; I don't know **whether** he'll come."),
                R("its", "possessive", "it's", "it is / it has", "The dog wagged **its** tail; **it's** raining."),
                R("continual", "repeated, often annoying", "continuous", "unbroken", "**Continual** interruptions; **continuous** noise."),
                R("considerable", "large", "considerate", "thoughtful of others", "A **considerable** sum; a **considerate** neighbour."),
                R("imaginary", "not real", "imaginative", "creative", "An **imaginary** friend; an **imaginative** design."),
                R("hard", "difficult; with effort", "hardly", "almost not", "Work **hard**; I **hardly** know her."),
                R("late", "not on time", "lately", "recently", "The train was **late**; I haven't seen him **lately**."),
                R("receipt", "proof of payment", "recipe", "cooking instructions", "Keep the **receipt**; a **recipe** for cake."),
                R("opportunity", "a chance to do something", "possibility", "the chance that something may happen", "An **opportunity** to travel; the **possibility** of rain."),
                R("salary", "fixed monthly pay", "wages", "weekly pay, often hourly", "She earns a good **salary**; the **wages** are paid on Fridays."),
                R("ashamed", "about one's own behaviour", "embarrassed", "uncomfortable in a situation", "**Ashamed** of lying; **embarrassed** about tripping.")
            )
        ),
        new LearnSection(
            "Remembering tricks",
            new Bullets(
                "*affect* is the **A**ction; *effect* is the **E**nd result.",
                "Something you **lose** once has one *o*; something **loose** has more room — two *o*s.",
                "*principal* = your **pal** the head teacher; *principle* = a **rule** like *alpha* — both end the same as their meaning.",
                "*advice / practice / licence* end in **-ce** as nouns; *advise / practise / license* end in **-s(e)** as verbs.",
                "*rise* needs no helper — it rises alone; *raise* needs an object in its hands."
            )
        )
    );

    // ------------------------------------------------------------------ prepositional phrases

    private static readonly LearnLibrary.Topic PrepositionalPhrases = new(
        "prepositional-phrases", "Prepositional phrases", "50+ fixed phrases grouped by function — in time or on time, in the end or at the end, and the rest of the family.", "Vocabulary and usage",
        new LearnSection(
            "The big grouped table",
            new Table(
                ["Group", "Phrase", "Meaning", "Example"],
                R("Time", "in time (for / to)", "early enough", "We arrived **in time for** the start."),
                R("Time", "on time", "punctual, as scheduled", "The train left **on time**."),
                R("Time", "in the end", "finally, after everything", "**In the end,** we stayed at home."),
                R("Time", "at the end (of)", "final point of something", "**At the end of** the film, everyone cried."),
                R("Time", "at last", "finally, with relief", "**At last,** the results are out."),
                R("Time", "in advance", "beforehand", "Book **in advance** to save money."),
                R("Time", "at once / right away", "immediately", "Call me **at once**."),
                R("Time", "for the time being", "for now", "**For the time being,** nothing changes."),
                R("Time", "in the meantime", "while waiting", "Lunch is at one; **in the meantime**, let's plan."),
                R("Time", "in the long run", "over a long period", "**In the long run,** insulation pays for itself."),
                R("Time", "from time to time", "occasionally", "**From time to time** she calls."),
                R("Time", "at short notice", "with little warning", "They cancelled **at short notice**."),
                R("Time", "for good", "permanently", "She's back **for good**."),
                R("Concession", "in spite of / despite", "not prevented by", "**Despite** the forecast, we sailed."),
                R("Concession", "regardless of", "without considering", "They played **regardless of** the injuries."),
                R("Concession", "for all (one's) effort", "in spite of (formal/literary)", "**For all** his experience, he panicked."),
                R("Condition", "in case of", "if … happens (warnings)", "**In case of** fire, use the stairs."),
                R("Condition", "in the event of", "formal 'if … happens'", "**In the event of** a delay, meal vouchers are provided."),
                R("Condition", "on condition that", "only if (formal)", "He was freed **on condition that** he left the country."),
                R("Condition", "in the absence of", "if … is not available", "**In the absence of** evidence, the case collapsed."),
                R("Condition", "at all costs", "whatever it takes", "Avoid panic **at all costs**."),
                R("Place", "in sight / out of sight", "visible / not visible", "Land was **in sight**. The ship went **out of sight**."),
                R("Place", "on the outskirts of", "on the edge of a city", "They live **on the outskirts of** Granada."),
                R("Place", "in the distance", "far away but visible", "Lights appeared **in the distance**."),
                R("Place", "at the back of / in the corner of (a room)", "position inside", "Sit **at the back of** the bus, **in the corner of** the room."),
                R("Place", "on the corner / at the corner (of a street)", "street junction", "There's a bakery **on the corner**."),
                R("Place", "within reach of", "close enough to get to", "The flat is **within reach of** the beach."),
                R("Place", "off the coast (of)", "in the sea near", "An island lies **off the coast of** Corsica."),
                R("Place", "on the way (to)", "during the journey", "We stopped **on the way to** the airport."),
                R("Manner and degree", "by far", "by a large margin, with superlatives", "She's **by far** the best player."),
                R("Manner and degree", "by heart", "from memory", "I learnt the poem **by heart**."),
                R("Manner and degree", "by chance / by accident / by mistake", "not planned / wrongly", "I met her **by chance**. I took your bag **by mistake**."),
                R("Manner and degree", "on purpose", "deliberately", "He did it **on purpose**."),
                R("Manner and degree", "at least / at most", "not less / not more than", "**At least** a hundred came; **at most** a thousand."),
                R("Manner and degree", "in general / on the whole", "mostly, usually", "**On the whole,** reviews were positive."),
                R("Manner and degree", "in fact / as a matter of fact", "actually", "**In fact,** he was early."),
                R("Manner and degree", "on average / in total", "typically / altogether", "**On average,** we sell fifty a day."),
                R("Manner and degree", "in detail / in brief", "thoroughly / in short", "The plan was explained **in detail**. **In brief,** we proceed."),
                R("Manner and degree", "to some extent", "partly", "**To some extent** he's right."),
                R("Manner and degree", "at random", "without pattern", "Names were chosen **at random**."),
                R("Manner and degree", "without fail", "always, reliably", "He calls every Sunday **without fail**."),
                R("Cause", "because of / due to / owing to", "as a result of", "**Due to fog,** flights were delayed."),
                R("Cause", "on account of", "formal 'because of'", "The match was postponed **on account of** the weather."),
                R("Cause", "thanks to", "positive result", "**Thanks to** her, nobody was hurt."),
                R("Cause", "as a result of", "because of (neutral)", "**As a result of** the storm, the bridge closed."),
                R("Opinion", "in my opinion / in my view", "I think", "**In my opinion,** the sequel is better."),
                R("Opinion", "from my point of view", "as I see it", "**From my point of view,** it's a fair deal."),
                R("Opinion", "as far as I'm concerned", "personally", "**As far as I'm concerned,** the matter is closed."),
                R("Opinion", "in theory / in practice", "supposedly / in reality", "**In theory** it works; **in practice** it crashes."),
                R("State", "under threat / pressure / discussion / way", "in a state of", "The castle is **under threat**. A plan is **under way**."),
                R("State", "beyond doubt / recognition / repair", "past a limit", "The car was damaged **beyond repair**."),
                R("State", "out of the question", "impossible, not negotiable", "Another delay is **out of the question**."),
                R("State", "out of reach / order / stock / breath", "not available or functioning", "The lift is **out of order**."),
                R("State", "in danger / at risk", "unsafe", "The species is **at risk**."),
                R("State", "in a hurry / in a rush", "rushing", "I was **in a hurry** and forgot it."),
                R("State", "on strike / on duty / on business / on holiday", "engaged in an activity", "Judges are **on strike**."),
                R("State", "for sale / on sale", "available to buy (AmE: discounted)", "The house is **for sale**."),
                R("State", "in common / in touch / in charge of", "shared / in contact / responsible for", "We have a lot **in common**. Who is **in charge of** refunds?"),
                R("State", "on second thoughts", "reconsidering (BrE)", "**On second thoughts,** make it two.")
            )
        ),
        new LearnSection(
            "Pairs people mix up",
            new Table(
                ["Pair", "The difference", "Examples"],
                R("in time vs on time", "early enough vs punctual", "We got there just **in time** — it was starting. / The flight left **on time**."),
                R("in the end vs at the end", "final outcome vs final point of a thing", "**In the end** we sold the flat. / **At the end of** the concert, people stood up."),
                R("at the moment vs in a moment", "now vs very soon", "She's busy **at the moment**. Lunch is ready **in a moment**."),
                R("in the way vs on the way", "blocking vs en route", "The van was **in the way**. We bought petrol **on the way**."),
                R("by chance vs on purpose", "accidental vs deliberate", "We met **by chance**. He deleted it **on purpose**."),
                R("at sea vs by the sea", "sailing vs beside the coast", "He works **at sea**. A cottage **by the sea**.")
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
