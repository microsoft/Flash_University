#include<stdio.h>

void A()
{
    printf("func A\n");
}

//takes in a pointer (memory location)
void B(void (*ptr)())
{
    (*ptr) (); // callback to A
}
  
int main()
{
    A();
    //Basically we are setting the ptr variable to A and passing it into b?
    void (*ptr)() = &A;
    B(ptr);
   return 0;
}