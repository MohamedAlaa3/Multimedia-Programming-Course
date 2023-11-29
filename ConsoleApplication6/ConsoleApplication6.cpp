#include <iostream >
#include <vector>
#include <algorithm>
using namespace std;

// you can use includes, for example:
// #include <algorithm>

// you can write to stdout for debugging purposes, e.g.
// cout << "this is a debug message" << endl;

int solution(vector<int>& A) {
    // write your code in C++14 (g++ 6.2.0)
    int min = 1;
    for ( int& i : A)
    {
        if (min == A.at(i))
        {
            i = 0;
            min++;
        }
    }
    return min;
}


int main()
{
    cout << "Hello World!\n";
    vector<int> m = { 1,2,3 };
    m.push_back(6);
    for (const int& i : m) {
        cout << i << "  ";
    }
    //for(Cost)

    system("pause");
}

