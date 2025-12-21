using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace BridgeLabzApp
{
    public class Billing
    {
        private static readonly string connectionString =
            "Server=YOUR_SERVER_NAME;Database=POS_DB;Trusted_Connection=True;";
        
        public static void GenerateBill()
        {
            List<BillItem> items = new List<BillItem>
            {
                new BillItem { ProductId = 1, Quantity = 2, Price = 100 },
                new BillItem { ProductId = 2, Quantity = 1, Price = 200 }
            };

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("The conncetion is established");
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    
                    SqlCommand billCmd = new SqlCommand(
                        "INSERT INTO Bills (BillDate, TotalAmount) OUTPUT INSERTED.BillId VALUES (@date, @total)",
                        con, transaction);

                    decimal totalAmount = 0;
                    items.ForEach(i => totalAmount += i.Quantity * i.Price);

                    billCmd.Parameters.AddWithValue("@date", DateTime.Now);
                    billCmd.Parameters.AddWithValue("@total", totalAmount);

                    int billId = (int)billCmd.ExecuteScalar();

                    
                    foreach (var item in items)
                    {
                        
                        SqlCommand stockCmd = new SqlCommand(
                            "SELECT Stock FROM Inventory WHERE ProductId=@pid",
                            con, transaction);

                        stockCmd.Parameters.AddWithValue("@pid", item.ProductId);
                        int stock = Convert.ToInt32(stockCmd.ExecuteScalar());

                        if (stock < item.Quantity)
                        {
                            throw new Exception("Insufficient stock for ProductId: " + item.ProductId);
                        }

                        
                        SqlCommand updateStockCmd = new SqlCommand(
                            "UPDATE Inventory SET Stock = Stock - @qty WHERE ProductId=@pid",
                            con, transaction);

                        updateStockCmd.Parameters.AddWithValue("@qty", item.Quantity);
                        updateStockCmd.Parameters.AddWithValue("@pid", item.ProductId);
                        updateStockCmd.ExecuteNonQuery();

                        
                        SqlCommand itemCmd = new SqlCommand(
                            "INSERT INTO BillItems (BillId, ProductId, Quantity, Price) VALUES (@bid,@pid,@qty,@price)",
                            con, transaction);

                        itemCmd.Parameters.AddWithValue("@bid", billId);
                        itemCmd.Parameters.AddWithValue("@pid", item.ProductId);
                        itemCmd.Parameters.AddWithValue("@qty", item.Quantity);
                        itemCmd.Parameters.AddWithValue("@price", item.Price);
                        itemCmd.ExecuteNonQuery();
                    }

                    
                    transaction.Commit();
                    Console.WriteLine("Bill generated successfully.");
                }
                catch (Exception ex)
                {
                    
                    transaction.Rollback();
                    Console.WriteLine("Transaction failed: " + ex.Message);
                }
            }
        }
    }

    internal class BillItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    

    public static void Main()
        {

        }
    }
}
