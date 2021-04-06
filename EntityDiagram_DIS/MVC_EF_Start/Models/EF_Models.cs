using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDiagram_DIS.Models
{
  

public class Store
{

    [Key]
   [DatabaseGenerated(DatabaseGeneratedOption.None)]
   public int store_Id {get; set;}
  public string store_Name { get; set; }
 
  public List<Products> products { get; set; }

  public List<Orders> orders { get; set; }

    }

    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Product_Id { get; set; }

        public string name { get; set; }
        public int cost { get; set; }
        public List<OrderProductMap> Product_Orders { get; set; }

        public Store store { get; set; }
    }

    public class Orders
{
  [Key]
 [DatabaseGenerated(DatabaseGeneratedOption.None)]
 public int Order_Id {get;set;}
  public int Order_Total {get; set;}
  public Store store { get; set; }

  public List<OrderProductMap> Order_Products {get;set;}
}


public class OrderProductMap
{

    public int Id { get; set; }
    public Orders order {get;set;}
   public Products product {get;set;}

   public int ProductQuantity{get;set;}

}



}