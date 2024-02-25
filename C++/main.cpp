#include<iostream>

int main(){

    std::cout << "Operator: ";
    char[0] operator_;
    while(true){
        std::cin >> char[0] operator_;
        if(
            operator_ == "+"
            || operator_ == "-"
            || operator_ == "*"
            || operator_ == "/"
        ) break;
        else std::cout << "Invalid operator!";
    }

    float x_;
    while(true){
        std::cin >> float x_;
        try{
            (int)x_;
            break;
        }
        catch{std::cout << "Invalid input!"}
    }

    float y_;
    while(true){
        std::cin >> float y_;
        try{
            (int)y_;
            break;
        }
        catch{std::cout << "Invalid input!"}
    }

    switch(operator_){
        case "+":
            std::cout << (float)x_ + (float)y_;
            break;
        case "-":
            std::cout << (float)x_ - (float)y_;
            break;
        case "*":
            std::cout << (float)x_ * (float)y_;
            break;
        case "/":
            std::cout << (float)x_ / (float)y_;
            break;
    }

    return 0;

}


/*
    Var noe problemer med GNU, så kunne ikke compile denne, men bør funke.
    Har ikke jobbet veldig mye med C++, og derfor ble det litt vanskelig å skrive 'blindt' uten å teste.
*/