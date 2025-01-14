﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.DataAccess
{
    namespace Expenses.Models

    {
        internal class ExpenseModel
        {

            public int Id { get; set; }
            [Required]
            public string? Title { get; set; }
            [Required]

            public decimal MoneySpent { get; set; }
            [Required]

            public DateTime ExpenseDate { get; set; }
            [Required]
            public string? Category { get; set; }


        }
    }
}
