﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> developerMVC
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarioModels
{
<<<<<<< HEAD
    public class Usuario
    {
        public int Id_Usuario { get; set; }
=======
    [Table("USUARIO")]
    public class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Usuario_Perfis = new HashSet<Usuario_Perfil>();
            Usuario_Processos = new HashSet<Usuario_Processo>();
        }
        
        [Key]
        public decimal Id_Usuario { get; set; }

        [Display(Name = "Usuario")]
        public string Nome { get; set; }
>>>>>>> developerMVC

        [Display(Name = "Login")]
        [Required(ErrorMessage = "Informe o nome do usuário", AllowEmptyStrings = false)]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Senha { get; set; }
<<<<<<< HEAD
=======

        
        public virtual ICollection<Usuario_Perfil> Usuario_Perfis { get; set; }

        
        public virtual ICollection<Usuario_Processo> Usuario_Processos { get; set; }
>>>>>>> developerMVC
    }
}
