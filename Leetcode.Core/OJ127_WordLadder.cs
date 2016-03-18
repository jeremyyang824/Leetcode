using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given two words (beginWord and endWord), and a dictionary's word list, find the length of shortest transformation sequence from beginWord to endWord, such that:
     * Only one letter can be changed at a time
     * Each intermediate word must exist in the word list
     * 
     * For example,
     * Given:
     * beginWord = "hit"
     * endWord = "cog"
     * wordList = ["hot","dot","dog","lot","log"]
     * As one shortest transformation is "hit" -> "hot" -> "dot" -> "dog" -> "cog",
     * return its length 5.
     * 
     * Note:
     * Return 0 if there is no such transformation sequence.
     * All words have the same length.
     * All words contain only lowercase alphabetic characters.
     * 
     * 类似题目：OJ072_EditDistance
     */
    public class OJ127_WordLadder
    {
        /*
         * this is a search problem, and breath-first search guarantees the optimal solution.
         */
        public int LadderLength(string beginWord, string endWord, HashSet<string> wordList)
        {
            wordList.Add(endWord);

            Queue<WordNode> queue = new Queue<WordNode>();
            queue.Enqueue(new WordNode(beginWord, 1));   //首个节点

            while (queue.Count > 0)
            {
                WordNode current = queue.Dequeue(); //当前可达（并检测的）路径节点
                if (current.Word == endWord)
                    return current.NumSteps;    //找到出口并退出

                char[] arr = current.Word.ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        //尝试逐个替换字符
                        char temp = arr[i];
                        if (arr[i] != c)
                            arr[i] = c;

                        string newWord = new String(arr);
                        if (wordList.Contains(newWord))
                        {
                            //找到新的路径节点
                            queue.Enqueue(new WordNode(newWord, current.NumSteps + 1));
                            wordList.Remove(newWord);
                        }

                        arr[i] = temp;  //换回替换的字符！
                    }
                }
            }

            return 0;
        }
    }

    public class WordNode
    {
        public string Word { get; set; }
        public int NumSteps { get; set; }

        public WordNode(string word, int numSteps)
        {
            this.Word = word;
            this.NumSteps = numSteps;
        }
    }
}
