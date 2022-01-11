using System;
using System.Collections;
using System.Collections.Generic;

public class Game
{
    private readonly LinkedList<int> first;
    private readonly LinkedList<int> second;

    public Game(LinkedList<int> first, LinkedList<int> second)
    {
        this.first = first;
        this.second = second;
    }

    public IEnumerator<string> GetEnumerator()
    {
        bool firstPlayer = true;

        while (true)
        {
            if (first.Count == 0 && second.Count != 0)
            {
                yield return "First win!";
                break;
            }
            if (first.Count == 0 && second.Count != 0)
            {
                yield return "Second win!";
                break;
            }

            if (firstPlayer)
            {
                if (first.First.Value >= second.First.Value)
                {
                    yield return $"First: {first.First.Value}";
                    first.RemoveFirst();
                }
                else if (first.First.Next == null)
                {
                    yield return "Second win!";
                    break;
                }
                else
                {
                    int countNoods = 0;

                    var node = first.First;
                    first.RemoveFirst();
                    first.AddLast(node);

                    while (countNoods < first.Count)
                    {
                        if (first.First.Value >= second.First.Value)
                        {
                            yield return $"First: {first.First.Value}";
                            first.RemoveFirst();
                            break;
                        }
                        else
                        {
                            node = first.First;
                            first.RemoveFirst();
                            first.AddLast(node);
                        }

                        countNoods++;
                    }

                    if (countNoods == first.Count)
                    {
                        yield return "Second win!";
                        break;
                    }
                }

                firstPlayer = false;
            }
            else
            {
                if (second.First.Value >= first.First.Value)
                {
                    yield return $"Second: {second.First.Value}";
                    second.RemoveFirst();
                }
                else if (second.First.Next == null)
                {
                    yield return "First win!";
                    break;
                }
                else
                {
                    int countNoods = 0;

                    var node = second.First;
                    second.RemoveFirst();
                    second.AddLast(node);

                    while (countNoods < second.Count)
                    {
                        if (second.First.Value >= first.First.Value)
                        {
                            yield return $"Second: {second.First.Value}";
                            second.RemoveFirst();
                            break;
                        }
                        else
                        {
                            node = second.First;
                            second.RemoveFirst();
                            second.AddLast(node);
                        }

                        countNoods++;
                    }

                    if (countNoods == second.Count)
                    {
                        yield return "First win!";
                        break;
                    }
                }

                firstPlayer = true;
            }
        }
    }

    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}