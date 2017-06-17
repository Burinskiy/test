// testdeliteli.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;


void main() {
	int n, num, dil, rez;
	cin >> num;
	n = 1;
	while (n <= sqrt(num)) {
		rez = num%n;
		dil = num / n;
		if (rez == 0) {
			cout << n<<endl;
			if (n != dil) {
				cout << dil<<endl;
			}
			n = n + 1;
		}
	}
	system("pause");
}

