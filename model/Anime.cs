using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamimiProofei.model
{
    class Anime
    {
        private int idAnime;
        private String nomeAnime;
        private String estudio;
        private int numEps;
        private String dataLanc;
        private String sinopse;
        private byte[] fotoAnime = null;
        private DateTime dataPicker;
        private String valAnime;


        public void setIdAnime(int idAnime)
        {
            this.idAnime = idAnime;
        }
        public int getIdAnime()
        {
            return idAnime;
        }

        public void setNomeAnime(String nomeAnime)
        {
            this.nomeAnime = nomeAnime;
        }
        public String getNomeAnime()
        {
            return nomeAnime;
        }

        public void setEstudio(String estudio)
        {
            this.estudio = estudio;
        }
        public String getEstudio()
        {
            return estudio;
        }

        public void setNumEps(int numEps)
        {
            this.numEps = numEps;
        }
        public int getNumEps()
        {
            return numEps;
        }

        public void setDataLanc(String dataLanc)
        {
            this.dataLanc = dataLanc;
        }
        public String getDataLanc()
        {
            return dataLanc;
        }

        public void setSinopse(String sinopse)
        {
            this.sinopse = sinopse;
        }
        public String getSinopse()
        {
            return sinopse;
        }

        public void setFotoAnime(byte[] fotoAnime)
        {
            this.fotoAnime = fotoAnime;
        }
        public byte[] getFotoAnime()
        {
            return fotoAnime;
        }

        public void setDataPicker(DateTime dataPicker)
        {
            this.dataPicker = dataPicker;
        }
        public DateTime getDataPicker()
        {
            return dataPicker;
        }

        public void setValAnime(String valAnime)
        {
            this.valAnime = valAnime;
        }
        public String getValAnime()
        {
            return valAnime;
        }
    }
}
