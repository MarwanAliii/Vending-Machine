public class VendingMachine {
//declaring 4 instance variables
//restricting instance variable visibility with &#39;private&#39; in order to
//protect the value of the variables when the code runs
private String productName;
private double price;
private int maxQuantity = 50;
private int currentStock;
//1st Constructor (no arguments)
VendingMachine(){
}
//2nd Constructor
VendingMachine(String s, double p, int cs){
productName = s;
price = p;
currentStock = cs;
}
//method #1: returns the name of the product
public String getProdName(){
return productName;
}
//method #2: retrieves current price
public double getPrice(){
return price;
}
//method #3: sets a new price
public void setPrice(double newprice){
price = newprice;
}
//method #4: retrieves current level of stock
public int getCurrentStock(){
return currentStock;

}
//method #5: decreases current level of stock
public void stockDecrease(){
currentStock--;
}
//method #6: returns cost of product * the number that can be sold
public double checkTotalSales(){
return price * (maxQuantity - currentStock);
}
//main method
public static void main(String[] args){
//First Object
VendingMachine Snickers = new VendingMachine(&quot;Snickers&quot;, 2.0, 50);
System.out.println(&quot;Product #1----------------------------------&quot; + &quot;\n&quot; + &quot;Current

product name: &quot;+ Snickers.getProdName());

System.out.println(&quot;Current product price: $&quot;+ Snickers.getPrice());
Snickers.stockDecrease();
System.out.println(&quot;Current product stock: &quot;+ Snickers.getCurrentStock());
System.out.println(&quot;Check product sales: $&quot;+ Snickers.checkTotalSales());
Snickers.setPrice(2.50);
System.out.println(&quot;Future product price: $&quot;+ Snickers.getPrice());
//Second Object
VendingMachine Lays = new VendingMachine(&quot;Lays&quot;, 1.0, 50);
System.out.println(&quot;Product #2----------------------------------&quot; + &quot;\n&quot; + &quot;Current

product name: &quot;+ Lays.getProdName());

System.out.println(&quot;Current product price: $&quot;+ Lays.getPrice());
Lays.stockDecrease();
System.out.println(&quot;Current product stock: &quot;+ Lays.getCurrentStock());
System.out.println(&quot;Check product sales: $&quot;+ Lays.checkTotalSales());
Lays.setPrice(1.50);
System.out.println(&quot;Future product price: $&quot;+ Lays.getPrice());
//Third Object
VendingMachine Coke = new VendingMachine(&quot;Coke&quot;, 1.5, 50);
System.out.println(&quot;Product #2----------------------------------&quot; + &quot;\n&quot; + &quot;Current

product name: &quot;+ Coke.getProdName());

System.out.println(&quot;Current product price: $&quot;+ Coke.getPrice());
Coke.stockDecrease();
System.out.println(&quot;Current product stock: &quot;+ Coke.getCurrentStock());
System.out.println(&quot;Check product sales: $&quot;+ Coke.checkTotalSales());

Coke.setPrice(2.0);
System.out.println(&quot;Future product price: $&quot;+ Coke.getPrice());
//Fourth Object
VendingMachine Sprite = new VendingMachine(&quot;Sprite&quot;, 1.5, 50);
System.out.println(&quot;Product #2----------------------------------&quot; + &quot;\n&quot; + &quot;Current

product name: &quot;+ Sprite.getProdName());

System.out.println(&quot;Current product price: $&quot;+ Sprite.getPrice());
Sprite.stockDecrease();
System.out.println(&quot;Current product stock: &quot;+ Sprite.getCurrentStock());
System.out.println(&quot;Check product sales: $&quot;+ Sprite.checkTotalSales());
Sprite.setPrice(2.0);
System.out.println(&quot;Future product price: $&quot;+ Sprite.getPrice());
//Fifth Object
VendingMachine Hershey = new VendingMachine(&quot;Hershey&quot;, 1.5, 50);
System.out.println(&quot;Product #2----------------------------------&quot; + &quot;\n&quot; + &quot;Current

product name: &quot;+ Hershey.getProdName());

System.out.println(&quot;Current product price: $&quot;+ Hershey.getPrice());
Hershey.stockDecrease();
System.out.println(&quot;Current product stock: &quot;+ Hershey.getCurrentStock());
System.out.println(&quot;Check product sales: $&quot;+ Hershey.checkTotalSales());
Hershey.setPrice(2.0);
System.out.println(&quot;Future product price: $&quot;+ Hershey.getPrice());
}
}
