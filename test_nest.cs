using System;
using System.Collections;

namespace Chap4.exmpls{

class myConstructors : testNest
{
	static void Main(string[] args){

		testNest myNest = new testNest();
		
	}
}

public class testNest{
		
		public testNest(){
		subClass cust1 = new subClass(10);
		Console.WriteLine("");
		subClass cust2 = new subClass();
		}
		
		abstract class GenericCustomer
		 {
			protected ArrayList rates = new ArrayList();
			public GenericCustomer(int rate){
			Console.WriteLine("From Overloaded Parent Constructor");
			rates.Add(rate);
			}
			public GenericCustomer(){
			Console.WriteLine("From Default Parent Constructor");
			rates.Add("the default base always runs all the way up the hierarchy");
			}
		 }


		 
		 class subClass : GenericCustomer
		 {
			public subClass(int rate) : this(){
			  Console.WriteLine("from Subclass with parameter Constructor");
			  rates.Add(rate);
			  
				for (int i=0 ;i<rates.Count ;i++){
					Console.WriteLine(rates[i]);
				}
			}
			
			public subClass(){
			Console.WriteLine("From Subclass without param construct");
			}
			
			
		 }

	}
}