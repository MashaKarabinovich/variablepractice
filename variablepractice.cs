#include <iostream>
#include <cstdio>
using namespace std;

int main() {
   int a;
    long l; char c;
    float  f; double d; //all the variables needed
    cin>>a>>l>>c>>f>>d; //enter them in
    cout<<a<<endl<<l<<endl<<c<<endl; //call it out
    cout.precision(3);
    cout<<fixed<<f<<endl;
    cout.precision(9);
    cout<<fixed<<d;
    return 0;
}
