using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusLove.src.modules.Users.Domain.Entities;

public class User
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Contraseña { get; set; } = string.Empty;
    public int Edad { get; set; }
    public string Carrera { get; set; } = string.Empty;
    public string Intereses { get; set; } = string.Empty;
    
    }
