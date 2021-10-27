using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProductMaintenance
{
    public static class ProductDB
    {
        public static Product GetProduct(string code)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string selectStatement
                = "SELECT ProductCode, Description, UnitPrice "
                + "FROM Products "
                + "WHERE ProductCode = @ProductCode ";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductCode", code);

            try
            {
                connection.Open();
                SqlDataReader prodReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (prodReader.Read())
                {
                    Product product = new Product();

                    product.Code = (string)prodReader["ProductCode"];
                    product.Description = prodReader["Description"].ToString();
                    product.Price = ((decimal)prodReader["UnitPrice"]);

                    return product;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        
        public static int AddProduct(Product product)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string insertStatement =
                "INSERT Products " +
                "(ProductCode, Description, UnitPrice) " +
                "VALUES (@ProductCode, @Description, @UnitPrice)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@ProductCode", product.Code);
            insertCommand.Parameters.AddWithValue(
                "@Description", product.Description);
            insertCommand.Parameters.AddWithValue(
                "@UnitPrice", product.Price);

            try
            {
                connection.Open();

                int productCount = insertCommand.ExecuteNonQuery();
                return productCount;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }


       public static bool UpdateProduct(Product oldProduct, Product newProduct)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string updateStatement =
                "UPDATE Products SET " +
                "ProductCode = @NewProductCode, " +
                "Description = @NewDescription, " +
                "UnitPrice = @NewUnitPrice " +
                "WHERE ProductCode = @OldProductCode " +
                "AND Description = @OldDescription " +
                "AND UnitPrice = @OldUnitPrice ";

            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue(
                "@NewProductCode", newProduct.Code);
            updateCommand.Parameters.AddWithValue(
                "@NewDescription", newProduct.Description);
            updateCommand.Parameters.AddWithValue(
                "@NewUnitPrice", newProduct.Price);
            updateCommand.Parameters.AddWithValue(
                "@OldProductCode", oldProduct.Code);
            updateCommand.Parameters.AddWithValue(
                "@OldDescription", oldProduct.Description);
            updateCommand.Parameters.AddWithValue(
                "@OldUnitPrice", oldProduct.Price);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
                                
        public static bool DeleteProduct(Product product)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string deleteStatement =
                "DELETE FROM Products " +
                "WHERE ProductCode = @ProductCode " +
                "AND Description = @Description " +
                "AND UnitPrice = @UnitPrice ";

            SqlCommand deleteCommand =
                new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue(
                "@ProductCode", product.Code);
            deleteCommand.Parameters.AddWithValue(
                "@Description", product.Description);
            deleteCommand.Parameters.AddWithValue(
                "@UnitPrice", product.Price);

            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
