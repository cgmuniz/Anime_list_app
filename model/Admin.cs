using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamimiProofei.model
{
    class Admin
    {
        private int idAdmin;
        private String nomeAdmin;
        private String emailAdmin;
        private String senhaAdmin;
        private String valNomeAdmin;
        private String valEmailAdmin;
        private String valSenhaAdmin;

        public void setIdAdmin(int idAdmin)
        {
            this.idAdmin = idAdmin;
        }
        public int getIdAdmin()
        {
            return idAdmin;
        }

        public void setNomeAdmin(String nomeAdmin)
        {
            this.nomeAdmin = nomeAdmin;
        }
        public String getNomeAdmin()
        {
            return nomeAdmin;
        }

        public void setEmailAdmin(String emailAdmin)
        {
            this.emailAdmin = emailAdmin;
        }
        public String getEmailAdmin()
        {
            return emailAdmin;
        }

        public void setSenhaAdmin(String senhaAdmin)
        {
            this.senhaAdmin = senhaAdmin;
        }
        public String getSenhaAdmin()
        {
            return senhaAdmin;
        }

        public void setValNomeAdmin(String valNomeAdmin)
        {
            this.valNomeAdmin = valNomeAdmin;
        }
        public String getValNomeAdmin()
        {
            return valNomeAdmin;
        }

        public void setValEmailAdmin(String valEmailAdmin)
        {
            this.valEmailAdmin = valEmailAdmin;
        }
        public String getValEmailAdmin()
        {
            return valEmailAdmin;
        }

        public void setValSenhaAdmin(String valSenhaAdmin)
        {
            this.valSenhaAdmin = valSenhaAdmin;
        }
        public String getValSenhaAdmin()
        {
            return valSenhaAdmin;
        }
    }
}
