using static PracticingCAE.Web.Components.Pages.LearnContent.LearnBlock;
using static PracticingCAE.Web.Components.Pages.LearnContent.LearnText;

namespace PracticingCAE.Web.Components.Pages.LearnContent;

/// <summary>Exam-technique cheat sheets, in canonical order.</summary>
public static class ExamTopics
{
    // ------------------------------------------------------------------ key word transformations

    private static readonly LearnLibrary.Topic KwtPatterns = new(
        "kwt-patterns", "Key word transformations", "Reading and Use of English Part 4: the transformations that come up again and again.", "Exam technique",
        new LearnSection(
            "The rules in one breath",
            new Bullets(
                "Answer in **2–5 words**, including the key word. A contraction (*don't*) counts as two words.",
                "Never change the key word in any way — same form, no adding -ing or -ed.",
                "The meaning must be the same: keep tense, modality, singular/plural and time words consistent.",
                "Contractions like *don't* or *hadn't* count as two words; *cannot* counts as one."
            )
        ),
        new LearnSection(
            "The recurring patterns",
            new Table(
                ["Pattern", "Key idea", "Example (prompt — key word)"],
                R("wish / if only", "present regret → past simple; past regret → past perfect", "*I regret not revising.* (**wish**) → *I **wish I had revised**.*"),
                R("had better", "strong advice about one occasion", "*It would be wise to leave now.* (**better**) → *You **had better leave** now.*"),
                R("causative have / get", "someone does it for you", "*A mechanic repaired my car.* (**had**) → *I **had my car repaired**.*"),
                R("passive reporting", "*It is said that…* or *sb is said to…*", "*People say he is rich.* (**said**) → *He **is said to be** rich.*"),
                R("comparatives", "*not as…as* → *less…than*; *the + comparative, the + comparative*", "*City life isn't as calm as village life.* (**less**) → *Village life is **less calm than** city life.*"),
                R("so / such", "*so* + adjective/adverb; *such* + (a/an) + adjective + noun", "*The box was so heavy that I dropped it.* (**such**) → *It was **such a heavy box that** I dropped it.*"),
                R("purpose clauses", "*in order to / so as to* + inf; *so that* + can/could", "*I whispered so that nobody would hear me.* (**order**) → *I whispered **in order not to be heard**.*"),
                R("phrasal verbs in the passive", "keep the tense; keep the particle", "*They cancelled the match because of rain.* (**off**) → *The match **was called off** because of rain.*"),
                R("inversion", "front the negative adverbial, question word order", "*I had never tasted anything so good.* (**never**) → ***Never had I** tasted anything so good.*"),
                R("reported speech", "backshift + pronouns + time words", "*I'll call you tomorrow,* he said. (**he**) → ***He said he would call me the next day**.*"),
                R("despite / although", "clause ↔ noun / -ing", "*Although she was tired, she finished.* (**despite**) → ***Despite being** tired, she finished.*"),
                R("too / enough", "*too + adj + to* = *not + adj + enough + to*", "*He is too young to drive.* (**enough**) → *He **is not old enough to** drive.*"),
                R("modal deduction", "*must / can't / might + have + V3*", "*I'm sure she took the keys.* (**must**) → *She **must have taken** the keys.*"),
                R("used to / be used to", "*used to* + base = past habit; *be used to* + -ing = accustomed", "*He played here as a child.* (**used**) → *He **used to play** here.*"),
                R("allow / let / suppose", "passive *be allowed to*; *be supposed to*", "*You can't park here.* (**allowed**) → *You **are not allowed to park** here.*")
            )
        ),
        new LearnSection(
            "Checking your answer",
            new DoDont(
                ["Count the words before moving on.", "Copy the tense of the prompt sentence.", "Re-read for meaning: is it still true?"],
                ["*~~Change the key word to fit your grammar.~~*", "*~~Write six words because the idea is richer.~~*", "*~~Ignore the pronoun and time-word changes in reported speech.~~*"])
        )
    );

    /// <summary>All topics in canonical order. Declared after the topics it lists so
    /// static initialisation sees non-null values.</summary>
    public static readonly LearnLibrary.Topic[] All = [KwtPatterns];
}
