#include<stdio.h>
#include<math.h>

int gt(int n){
	int gt = 1;
	for(int i = 1; i <= n; i++){
		gt *= i;
	}
	return gt;
}

int nt(int n ){
	if( n < 2)
		return 0;
	for(int i = 2 ; i <= sqrt(n); i++){
		if( n % i == 0){
			return 0;
		}
	}
	return 1;
}

long long tu(int n){
	long long sum = 0;
	for(int i = 1; i <= sqrt(n); i++){
		if( n % i == 0){
			sum += i;
			if( n/i != i){
				sum += n/i;
			}
		}
		
	}	
	
	return sum;
}

int scp(int n){
	int can = sqrt(n);
	if( can * can == n){
		return 1;
	}
	else return 0;
	
}

void pt(int n){
	for(int i = 2; i <= sqrt(n); i++){
		if( n % i == 0){ // i la thua so nguyen to
			while( n % i == 0){
				printf("%d ", i);
				n /= i;
			}
		}
		// neu chua pt ra thi n chinh la snt cuoi cung
		if( n != 1){
			printf("%d", n);
		}
	}
}



int main(){
	int n; 
	scanf("%d", &n);
	pt(n);
}
	
