#include<stdio.h>
#include<stdlib.h>

typedef struct
{
	long a,b;	
} Interval;

int compare(const void *a, const void *b)
{
	const Interval *ia = (const Interval *)a;
	const Interval *ib = (const Interval*)b;
	if(ia->b != ib->b)
		return (ia->b - ib->b);
	return (ia->a - ib->a);
}

int main()
{
	long n;
	long temp = 0;
	long result = 0;
	
	scanf("%ld",&n);
	
	Interval *arr = (Interval *)malloc(n * sizeof(Interval));
	
	for(int i=0;i<n;i++)
		scanf("%ld %ld",&arr[i].a,&arr[i].b);
		
	qsort(arr, n, sizeof(Interval), compare);
		
	for(int i=0;i<n;i++)
	{
		if(arr[i].a >= temp)
		{
			temp = arr[i].b;
			result++;
		}
	}
	
	printf("%ld",result);
	
	return 0;
}
