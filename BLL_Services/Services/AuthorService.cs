﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_Services.Validators;
using DAL_Data;
using DTO_Models;
using Microsoft.Data.SqlClient;


namespace BLL_Services.Services
{
    public class AuthorService
    {
        private readonly AuthorRepository AuthorRepository;
        private readonly AuthorValidator AuthorValidator;
        public AuthorService()
        {
            AuthorRepository = new AuthorRepository();
            AuthorValidator = new AuthorValidator();
        }

        //Auto-generate AuthorID
        public string GenerateAuthorID()
        {
            return EntityRepository.GenerateId("Authors", "AuthorID", "AUTH");
        }

        //Get all authors
        public List<Author> GetAuthors()
        {
            return AuthorRepository.GetAllAuthors();
        }

        //Search authors by stored procedure
        public List<Author> SearchAuthors(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException("Từ khóa không được để trống.", nameof(searchTerm));
            }
            return AuthorRepository.GetAuthorsByStoredProcedure("SearchAuthors", new SqlParameter("@SearchTerm", searchTerm));
        }


        //Get all authors by book ID
        public List<Author> GetAuthorsByBookId(string bookID)
        {
            if (string.IsNullOrWhiteSpace(bookID))
            {
                throw new ArgumentException("Mã sách không được để trống.", nameof(bookID));
            }
            return AuthorRepository.GetAuthorsByBookID(bookID);
        }


        //Add a new author
        public int AddAuthor(Author author)
        {
            if (author == null)
            {
                throw new ArgumentNullException(nameof(author), "Tác giả không được để trống.");
            }


            if (!AuthorValidator.IsValidAuthor(author))
            {
                throw new ArgumentException(AuthorValidator.ErrorMessage, nameof(author));
            }
            return AuthorRepository.Insert(author);
        }


        //Update an existing author
        public int UpdateAuthor(Author author)
        {
            if (author == null)
            {
                throw new ArgumentNullException(nameof(author), "Tác giả không được để trống.");
            }


            if (!AuthorValidator.IsValidAuthor(author))
            {
                throw new ArgumentException(AuthorValidator.ErrorMessage, nameof(author));
            }
            return AuthorRepository.Update(author);
        }


        //Delete an author
        public int DeleteAuthor(string authorID)
        {
            if (string.IsNullOrWhiteSpace(authorID))
            {
                throw new ArgumentException("Mã tác giả không được để trống.", nameof(authorID));
            }
            return AuthorRepository.Delete(authorID);
        }
    }
}
