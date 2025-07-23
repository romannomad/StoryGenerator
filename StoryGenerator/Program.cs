// Get input from the user
String noun;
String adj;
String noun2;
String verb;

Console.WriteLine("Please provide a noun: ");
noun = Console.ReadLine();

Console.WriteLine("Please provide an adjective: ");
adj = Console.ReadLine();

Console.WriteLine("Please provide another noun: ");
noun2 = Console.ReadLine();

Console.WriteLine("Please provide an verb: ");
verb = Console.ReadLine();

String story = "Even with " + noun + " protected by the " + adj + " spectacles, Dorothy and her " + noun2 + " were at first " + verb + " by the brilliancy of the wonderful City. The streets were lined with beautiful houses all built of green marble and studded everywhere with sparkling emeralds. They walked over a pavement of the same green marble, and where the blocks were joined together were rows of emeralds, set closely, and glittering in the brightness of the sun. The window panes were of green glass; even the sky above the City had a green tint, and the rays of the sun were green.";

Console.WriteLine("This is our final story: ");
Console.WriteLine(story);