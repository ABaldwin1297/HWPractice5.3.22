
//int[] nbrs = { 1, 2, 3, 4, 5 };

//var sum = 0;
//var index = 0;

//while(index < 5) {

//    sum = sum + nbrs[index]; // when I changed to * the build was good but looked like it was loading forever? 
//    index = index + 1;

//}

//Console.WriteLine($"The average is {sum/5}");



// Modulo example - think of it like a numerator / denominator problem - have to set those variables first
// then set 3rd variable "ans" and then 2 vars we named above as the math problem

//var num = 20;
//var den = 6;

//int ans = (num % den);

//Console.WriteLine($"answer equals {ans}");



//Console.Write($"Type an integer, "); // can only be ran once? 

//var ans = Console.ReadLine();
//var nbr = Convert.ToInt32(ans);

//if (nbr % 2 == 0) {
//    Console.WriteLine($"Even");
//} else {
//    Console.WriteLine($"Odd");



//var idx = 0; ------------------------------Slide 98

//for (idx = 0; idx <= 50; idx++) ; {
//    if (idx % 5 == 0 || idx % 7 == 0) ;
//    Console.WriteLine($"The total of numbers divisible by 5 or 7 = {idx}");
//}



// Slide 102 example

//int[] nbrs = {                                      // int[] is declaring an array of integers
//754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
//187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
//460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
//690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
//435, 643, 809, 874, 906, 620, 328, 369, 426, 561
//};

//var low = 1000;
//var high = 0;

//foreach(var nbr in nbrs) {
//    if (nbr > high) high = nbr;
//    if (nbr < low) low = nbr;
//}

//Console.WriteLine($" highest = {high}, lowest = {low}"  );




int[] nbrs = {                                        // find the average
754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
435, 643, 809, 874, 906, 620, 328, 369, 426, 561
};

var avg = 0;

