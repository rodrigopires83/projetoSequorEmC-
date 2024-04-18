using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Text.Json;
using projetoSequorEmC_.Models;

namespace projetoSequorEmC_.Services
{
    public class OrderService
    {
        private List<Production> _productions = new List<Production>();
        public string GetAllOrdersAsJson()
        
        {
            var orders = new List<Order>();
            return JsonSerializer.Serialize(orders);
        }

        
        public List<Production> GetProductionsByEmail(string email)
        {
            return _productions.Where(p => p.Email == email).ToList();
        }
    
        public ValidationResult ValidateProdution(Production production)
        {
            if (!UserExists(production.Email))
            {
                return new ValidationResult(false, "Usuário não cadastrado.");
            }
            return new ValidationResult(true, "");
        }

        private bool UserExists(string email)
        {
            return true;
        }

    }
    


    public class ValidationResult
    {
        public bool IsSuccess { get; private set; }
        public string ErrorMessage { get; private set; }

        public ValidationResult(bool isSuccess, string errorMessage)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
        }
    }
}
