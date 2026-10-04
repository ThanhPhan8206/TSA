#include<stdio.h>
#include<math.h>

int gt(int n ){
	long long gt = 1;
	for(int i = 1; i <=n; i++){
		gt *= i;
	}
	
	return gt;
}

double tinh(int n , double x){
	
	
	double S = 0;
	for(int i = 1; i <=n ; i++){
		S += pow(x,i)/gt(i);
	}
	
	return sqrt(S);
	
}



int main(){
	
	int n;
	double x;
	scanf("%d %lf", &n, &x);
	
	printf("%3.lf", tinh(n,x));
	
	
}