#include <iostream>

using namespace std;

int main(){
    cout << "Please input your name: ";//First ask for user input
    string input;//First declare a string variable
    cin >> input;//Reads input from user then puts it in "input"
    cout << "Hello " << input << endl;//Outputs user input

    cout << "Please input a number: ";//Ask user to input number
    int number;//Declare an int variable
    cin >> number;//Puts user input into "number"
    cout << "You have entered: " << number;//Outputs second user input.

    //You need to declare a variable before you can use cin to assign user input to the variable
    //cin will automatically convert the input into whatever type is being inputted
}
