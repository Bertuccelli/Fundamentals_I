void Loop() {
    for(int k = 1; k <= 255; k++){
        Console.WriteLine(k);
    }
}

Loop();

void NewLoop() {
    for(int m = 1; m <= 100; m++){
        bool divisibleByThree = m % 3 == 0;
        bool divisibleByFive = m % 5 == 0;
        if(divisibleByThree && divisibleByFive){
            continue;
        }
        else if (divisibleByThree){
            Console.WriteLine(m);
        }
        else if (divisibleByFive){
            Console.WriteLine(m);
        }
    }
}

NewLoop();

void FizzBuzz() {
    for(int i = 1; i <= 100; i++){
        bool divisibleByThree = i % 3 == 0;
        bool divisibleByFive = i % 5 == 0;
        if (divisibleByThree && divisibleByFive) {
            Console.WriteLine("FizzBuzz");
        }
        else if (divisibleByThree) {
            Console.WriteLine("Fizz");
        }
        else if (divisibleByFive) {
            Console.WriteLine("Buzz");
        }
        else {
            Console.WriteLine(i);
        }
    }
}

FizzBuzz();