#include <iostream>
using namespace std;
struct info
{
	char name;
	int salary;
	int age;
	int NoYears;
};
void main()
{
	info x[5];
	for (int i = 0; i < 5; i++)
	{
		cin >> x[i].name;
		cin >> x[i].salary;
		cin >> x[i].age;
		cin >> x[i].NoYears;
	}
	int tot = 0, count=0;
	for (int i = 0; i < 5; i++)
	{
		tot += x[i].salary;
		count++;
	}
	int avg = tot / count;
	int tot2 = 0, avg2, count2=0;
	cout << avg << endl;
	for (int i = 0; i < 5; i++)
	{
		if (x[i].name =='a'|| x[i].name == 'y')
		{
			count2++;
			tot2 += x[i].salary;
		}
	}
	avg = tot2 / count2;
	cout<<avg<<endl;


	for (int i = 0; i < 5; i++)
	{
		if (x[i].NoYears>5)
		{
			cout << x[i].name;
		}
	}

}