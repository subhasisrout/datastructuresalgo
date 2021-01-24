using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trie
{
    public class TrieNode
    {
        static readonly int ALPHABET_SIZE = 26; //for a-z. We will be only storing lowercase letters
        
        public TrieNode[] children = new TrieNode[ALPHABET_SIZE];
        public bool isEndOfWord { get; set; }
        public TrieNode()
        {
            isEndOfWord = false;
            for (int i = 0; i < ALPHABET_SIZE; i++)
                children[i] = null;
        }
    }
}
