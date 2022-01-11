using System;

public class Commit
{
    private int id;

    private string content;

    public int Id => id;

    public string Content => content;

    public Commit(int id, string content)
    {
        this.id = id;
        this.content = content;
    }
    public Commit() { }

    public static Commit MergeAllCommits(Commit[] commits, Commit mergeIn, Func<Commit, Commit, Commit> mergeCommits,
        Predicate<Commit> canCommitMerged)
    {
        Commit commit = new Commit();

        for (int i = 0; i < commits.Length; i++)
        {
            if (commits[i].Id == mergeIn.Id)
                throw new ArgumentException("Equal ids");

            if (canCommitMerged(commits[i]))
                mergeIn = mergeCommits(mergeIn, commits[i]);
        }

        return mergeIn;
    }

    public static Commit MergeCommits(Commit commit1, Commit commit2)
    {
        string content = commit1.Content + " " + commit2.Content;

        return new Commit(commit1.Id | commit2.Id, content);
    }

    public override string ToString()
    {
        return $"{id}: {content}";
    }
}