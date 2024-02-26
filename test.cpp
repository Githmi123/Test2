
#include <iostream>



int square(int x){
    return x*x;
}   



int main(){
    int value = 7;
    std::cout << "Square of " << value << " is " << square(value) << std::endl;
}