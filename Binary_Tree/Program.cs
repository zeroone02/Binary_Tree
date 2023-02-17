using Binary_Tree;

var tree = new Tree<int>();
tree.Add(1);
tree.Add(2);
tree.Add(123);
tree.Add(4);
tree.Add(3);
tree.Add(6412);
tree.Add(711);
tree.Add(832);
foreach (var item in tree.Inorder())
{
    Console.Write(item + " ");
}
