#include <iostream>

using namespace std;
int main() {
//    const int i = 5;
   int i = 10;   // C3892
   i++;   // C2105

   cout << i;
}