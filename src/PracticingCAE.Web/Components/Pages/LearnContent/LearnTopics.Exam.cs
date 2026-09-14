using static PracticingCAE.Web.Components.Pages.LearnContent.LearnBlock;
using static PracticingCAE.Web.Components.Pages.LearnContent.LearnText;

namespace PracticingCAE.Web.Components.Pages.LearnContent;

/// <summary>Exam-technique cheat sheets, in canonical order.</summary>
public static class ExamTopics
{
    // ------------------------------------------------------------------ key word transformations

    private static readonly LearnLibrary.Topic KwtPatterns = new(
        "kwt-patterns", "Key word transformations", "Reading and Use of English Part 4: the rules, and 24 recurring patterns with worked transformations.", "Exam technique",
        new LearnSection(
            "The rules in one breath",
            new Bullets(
                "Answer in **2–5 words**, including the key word. A contraction (*don't*) counts as two words; *cannot* counts as one.",
                "Never change the key word in any way — same form, no adding -ing or -ed.",
                "The meaning must be the same: keep tense, modality, singular/plural and time words consistent.",
                "Contracted forms are fine, but only if the word count still fits.",
                "If your answer is 6 words, it is wrong even if the grammar is perfect — cut something."
            )
        ),
        new LearnSection(
            "The recurring patterns",
            new Table(
                ["Pattern", "Example transformation", "Notes"],
                R("wish / regret (present)", "*I'm sorry I don't live nearer.* (**wish**) → *I **wish I lived** nearer.*", "present regret → past simple"),
                R("wish / regret (past)", "*I regret not revising.* (**wish**) → *I **wish I had revised**.*", "past regret → past perfect; *if only* works the same"),
                R("had better", "*It would be wise to leave now.* (**better**) → *You **had better leave** now.*", "bare infinitive after *better*"),
                R("would rather", "*I don't want you to pay.* (**rather**) → *I **would rather you didn't** pay.*", "*would rather + sb + past* for someone else's action"),
                R("causative have / get", "*A mechanic repaired my car.* (**had**) → *I **had my car repaired**.*", "*have + object + V3* — someone did it for you"),
                R("passive reporting", "*People say he is rich.* (**said**) → *He **is said to be** rich.*", "*sb is said/believed/known to do* — keep the tense of *that*-clause"),
                R("passive reporting (past)", "*People think she left the country.* (**thought**) → *She **is thought to have left** the country.*", "earlier action → *to have + V3*"),
                R("comparatives: not as… as", "*City life isn't as calm as village life.* (**less**) → *Village life is **less calm than** city life.*", "flip subject and adjective"),
                R("the + comparative", "*You get older and time goes faster.* (**the**) → ***The older** you get, **the faster** time goes.*", "double *the + comparative*"),
                R("so / such", "*The box was so heavy that I dropped it.* (**such**) → *It was **such a heavy box that** I dropped it.*", "*so + adj* ↔ *such + a + adj + noun*"),
                R("too / enough", "*He is too young to drive.* (**enough**) → *He **is not old enough to** drive.*", "negate the other clause and swap *too* ↔ *adj + enough*"),
                R("purpose: in order to", "*I whispered so that nobody would hear me.* (**order**) → *I whispered **in order not to be heard**.*", "watch for negative purpose: *in order not to*"),
                R("purpose: so as to", "*She got up early because she wanted to watch the sunrise.* (**as**) → *She got up early **so as to watch** the sunrise.*", "*so as to* + base form"),
                R("inversion: negative adverbial", "*I had never tasted anything so good.* (**never**) → ***Never had I** tasted anything so good.*", "front the adverbial, question word order"),
                R("no sooner… than", "*As soon as we left, it started to rain.* (**sooner**) → ***No sooner had we left than** it started to rain.*", "past perfect after *No sooner*; *than*, not *when*"),
                R("hardly… when", "*She arrived just as the film started.* (**hardly**) → ***Hardly had she arrived when** the film started.*", "*Hardly had + sb + V3 when*"),
                R("reported speech", "*'I'll call you tomorrow,' he said.* (**he**) → ***He said he would call me the next day**.*", "backshift + pronouns + time words"),
                R("despite / although", "*Although she was tired, she finished.* (**despite**) → ***Despite being** tired, she finished.*", "clause ↔ noun / -ing; watch the subject"),
                R("modal deduction", "*I'm sure she took the keys.* (**must**) → *She **must have taken** the keys.*", "*must / can't + have + V3* for past certainty"),
                R("phrasal verbs in the passive", "*They cancelled the match because of rain.* (**off**) → *The match **was called off** because of rain.*", "keep the tense; keep the particle"),
                R("used to", "*He played here as a child.* (**used**) → *He **used to play** here.*", "past habit; never with state verbs in the present"),
                R("be used to", "*Living alone is normal for me.* (**used**) → *I **am used to living** alone.*", "*be used to + -ing* = accustomed; contrast with *used to + base*"),
                R("be allowed to", "*You can't park here.* (**allowed**) → *You **are not allowed to park** here.*", "permission passive; *let* has no passive"),
                R("be supposed to", "*The plane was scheduled to leave at six.* (**supposed**) → *The plane **was supposed to leave** at six.*", "arrangement/expectation, often one that failed"),
                R("gerund subject", "*It's hard to learn three languages.* (**learning**) → ***Learning** three languages is hard.*", "*-ing* phrase replaces *it + adjective + to*")
            )
        ),
        new LearnSection(
            "Checking your answer",
            new Table(
                ["Check", "Ask yourself", "Example of a slip"],
                R("word count", "2–5 words including the key word?", "*~~needn't to have brought~~* — 5 words, still wrong because the grammar fails"),
                R("key word untouched", "Have I added an ending to it?", "*~~despited~~*, *~~althoughs~~* — key word must keep its exact form"),
                R("same meaning", "Does the second sentence say exactly the same?", "*He stopped smoking* ≠ *He stopped to smoke*"),
                R("same grammar", "Same tense, same singular/plural, same time words?", "*'tomorrow' left unbackshifted in reported speech*"),
                R("spelling and contractions", "Would an examiner read *don't* as two words?", "count it as two before deciding the answer fits")
            )
        ),
        new LearnSection(
            "Habits of high scorers",
            new DoDont(
                ["Identify which pattern the key word signals before writing anything.", "Write the skeleton first (*She … to have …*) and fill the words in.", "Re-read both sentences side by side and count the words."],
                ["*~~Start from the prompt sentence and translate word by word.~~*", "*~~Use more words 'to be safe'.~~*", "*~~Ignore pronoun and time-word changes in reported speech.~~*"])
        )
    );

    /// <summary>All topics in canonical order. Declared after the topics it lists so
    /// static initialisation sees non-null values.</summary>
    public static readonly LearnLibrary.Topic[] All = [KwtPatterns];
}
