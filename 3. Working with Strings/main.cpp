#include <iostream>

using namespace std;
int main(){
    string text1 = "Hello ";//This is the first string, note the space in the back
    string text2 = "Fred";//This is the second string.
    cout << text1 << endl; //Output text1
    cout << text2 << endl; //Output text2
    cout << text1 << text2 << endl;//Outputs both of them

    string text3 = text1 + text2;//They can be combined
    cout << text3 << endl;//This have the same effect as the third output
}
