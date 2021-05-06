using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using TabloidCLI.Models;
using TabloidCLI.Repositories;

namespace TabloidCLI
{
    public class JournalRepository : DatabaseConnector, IRepository<Journal>
    {
        public JournalRepository(string connectionString) : base(connectionString) { }

        public List<Journal> GetAll()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT id,
                                               Title,
                                               Content,
                                               CreateDateTime
                                          FROM Journal";

                    List<Journal> journalEntries = new List<Journal>();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Journal journal = new Journal()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Title = reader.GetString(reader.GetOrdinal("Title")),
                            Content = reader.GetString(reader.GetOrdinal("Content")),
                            CreateDateTime = reader.GetDateTime(reader.GetOrdinal("CreateDateTime")),
                        };
                        journalEntries.Add(journal);
                    }

                    reader.Close();

                    return journalEntries;
                }
            }
        }

        public Journal Get(int id)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT Id,
                                               Title,
                                               Content,
                                               CreateDateTime
                                        FROM Journal WHERE Id = @id";

                    cmd.Parameters.AddWithValue("@id", id);

                    Journal journalEntry = null;

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (journalEntry == null)
                        {
                            journalEntry = new Journal()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Title = reader.GetString(reader.GetOrdinal("Title")),
                                Content = reader.GetString(reader.GetOrdinal("Content")),
                                CreateDateTime = reader.GetDateTime(reader.GetOrdinal("CreateDateTime"))
                            };
                        }

                        //if (!reader.IsDBNull(reader.GetOrdinal("TagId")))
                        //{
                        //    author.Tags.Add(new Tag()
                        //    {
                        //        Id = reader.GetInt32(reader.GetOrdinal("TagId")),
                        //        Name = reader.GetString(reader.GetOrdinal("Name")),
                        //    });
                        //}
                    }

                    reader.Close();

                    return journalEntry;
                }
            }
        }

        public void Insert(Journal journalEntry)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO Journal (Title, Content, CreateDateTime)
                                                     VALUES (@title, @content, @createDateTime)";
                    cmd.Parameters.AddWithValue("@title", journalEntry.Title);
                    cmd.Parameters.AddWithValue("@content", journalEntry.Content);
                    _ = cmd.Parameters.AddWithValue("@createDateTime", SqlDbType.DateTime2);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Journal journalEntry)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"UPDATE Journal 
                                           SET Title = @title,
                                               Content = @content,
                                               CreateDateTime= createDateTime
                                         WHERE id = @id";

                    cmd.Parameters.AddWithValue("@title", journalEntry.Title);
                    cmd.Parameters.AddWithValue("@content", journalEntry.Content);
                    cmd.Parameters.AddWithValue("@createDateTime", journalEntry.CreateDateTime);
                    cmd.Parameters.AddWithValue("@id", journalEntry.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"DELETE FROM Journal WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InsertTag(Journal author, Tag tag)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO AuthorTag (AuthorId, TagId)
                                                       VALUES (@authorId, @tagId)";
                    cmd.Parameters.AddWithValue("@authorId", author.Id);
                    cmd.Parameters.AddWithValue("@tagId", tag.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //public void DeleteTag(int authorId, int tagId)
        //{
        //    using (SqlConnection conn = Connection)
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = conn.CreateCommand())
        //        {
        //            cmd.CommandText = @"DELETE FROM AuthorTAg 
        //                                 WHERE AuthorId = @authorid AND 
        //                                       TagId = @tagId";
        //            cmd.Parameters.AddWithValue("@authorId", authorId);
        //            cmd.Parameters.AddWithValue("@tagId", tagId);

        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}