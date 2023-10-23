using Microsoft.VisualBasic;
using System;
internal class Program {
    //Given an array of strings strs, group the anagrams together.
    //You can return the answer in any order.

    //An Anagram is a word or phrase formed by rearranging the letters of 
    //a different word or phrase, typically using all the original letters exactly once.


    private static void Main(string[] args) {
    }

    public void /*IList<IList<string>>*/ GroupAnagrams(string[] strs) {

        Dictionary<char,int> counts = new Dictionary<char,int>();

        for (int i = 0; i < strs.Length; i++) {
            for (int j = 0; j < strs[i].Length; j++) {
                char word = strs[i][j]; 

                if (counts.ContainsKey(word)) {
                    counts[word]++;
                }

                counts[word] = j+1;

                
            }

        }
        
    }
}