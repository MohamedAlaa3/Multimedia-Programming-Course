// ConsoleApplication4.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

int main()
{
    char x = 'a';
    char y = 'z';
    int k = 2;
    while (x != y)
    {
        x += k;
        std::cout << x <<"\n";
        for (int i = 0; i < 3; i++)
        {
            y--;
        }
        std::cout << y << "\n";
        x = y++ + 2;
        std::cout << x++ << "\n";
        std::cout << y++ << "\n";
        std::cout << y++ << "\n";



    }


}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
