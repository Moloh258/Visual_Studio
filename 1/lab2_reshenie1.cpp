#include <iostream>

int main()
{
	setlocale(LC_ALL, "Russian");

	int a, b, c, max, min;
	printf("Введите числа");
	scanf_s("%d", &a);
	scanf_s("%d", &b);
	scanf_s("%d", &c);
	if (a > b) {
		max = a;
		min = b;
	}
	else {
		max = b;
		min = a;
	}
	if (c > max) {
		max = c;
	}
	else {
		if (c < min) {
			min = c;
		}
	}
	printf("Наибольшее число:%d \n", max);
	printf("Наименьшее число:%d \n", min);
	system("pause");
}




