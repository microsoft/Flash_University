#include <stdio.h>
#include <iostream>
using namespace std;
int main()
{
 	int * q = new int;
	
	int meaningOfLife = 41;

	if (meaningOfLife != 42){
		delete q;
		cout<<"According to Douglass Adams, we have failed";
	} else{
		cout << "Hooray, the meaning of life is " << meaningOfLife;
	}
	
	return 0;
}
