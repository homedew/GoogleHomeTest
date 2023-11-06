// See https://aka.ms/new-console-template for more information

using static System.Runtime.InteropServices.JavaScript.JSType;

List<int?> tc1 = new List<int?> { 4, 5, 7, 12, 1, null, 8 };
List<int?> tc2 = new List<int?> { 4, 5, 7, 8 ,12 , null, null, null};

GenericTree tree1 = new GenericTree();
Node root1 = tree1.NewNode(4);
tree1.AddChild(root1, tree1.NewNode(5));
tree1.AddChild(root1, tree1.NewNode(7));

tree1.AddChild(root1.children[0], tree1.NewNode(12));
tree1.AddChild(root1.children[0], tree1.NewNode(1));
tree1.AddChild(root1.children[1], tree1.NewNode(8));


var test1 = tree1.MostLeftRightSide(root1);
Console.WriteLine("TC1");


foreach (int number in test1)
{
    Console.Write(number + "\t");
}


GenericTree tree2 = new GenericTree();
Node root2 = tree2.NewNode(4);
tree2.AddChild(root2, tree2.NewNode(5));
tree2.AddChild(root2, tree2.NewNode(7));
tree2.AddChild(root2, tree2.NewNode(8));
tree2.AddChild(root2.children[0], tree2.NewNode(12));


Console.WriteLine("\nTC2");

var test2 = tree2.MostLeftRightSide(root2);

foreach (int number in test2)
{
    Console.Write(number + "\t");
}