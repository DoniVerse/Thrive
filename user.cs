﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 

namespace thrive
{
    internal class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        private string connectionString = "server=localhost;database=Thrive;user=root;password=;";
        public static bool IsValidEmail(string email)
        {
            // Regex pattern to ensure email ends with @gmail.com
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }
        public static string HashPassword(string password)
        {
            // Generate a hashed password using Bcrypt
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Verify the entered password against the hashed password
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
        public bool Register()
        {
            try
            {
                if (!IsValidEmail(Email!))
                {
                    MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if user already exists
                    string checkQuery = "SELECT COUNT(*) FROM User WHERE UserName = @UserName OR Email = @Email";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@UserName", UserName);
                        checkCommand.Parameters.AddWithValue("@Email", Email);

                        int userCount = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (userCount > 0)
                        {
                            MessageBox.Show("User with this name and email already exist.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    string hashedPassword = HashPassword(Password!);
                    // Insert the new user
                    string insertQuery = "INSERT INTO User (UserName, Email, Password) VALUES (@UserName, @Email, @Password);";
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@UserName", UserName);
                        insertCommand.Parameters.AddWithValue("@Email", Email);
                        insertCommand.Parameters.AddWithValue("@Password", hashedPassword); // Remember to hash the password

                        insertCommand.ExecuteNonQuery(); // Execute the command
                        UserId = (int)insertCommand.LastInsertedId; // Get the inserted ID
                    }

                    return true; // Registration successful
                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred during registration: " + ex.Message);
                return false;
            }
        }
        public bool login(string username,string email, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if user exists
                    string selectQuery = "SELECT Password FROM User WHERE Email = @Email";
                    using (var selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@Email", email);
                        var result = selectCommand.ExecuteScalar();

                        if (result != null)
                        {
                            string storedHashedPassword = result.ToString()!;
                            if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                            {
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                

                                return true;
                            }
                        }

                        MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }


    }
}