namespace DataStructures.Trie
{
    public class Node
    {
        public char Char { get; set; }
        public bool IsWord { get; set; }
        public Node[] Children { get; set; }

        public Node(char c)
        {
            this.Char = c;
            this.IsWord = false;
            this.Children = new Node[26]; //for a-z. We will be only storing lowercase letters
        }
    }
}
