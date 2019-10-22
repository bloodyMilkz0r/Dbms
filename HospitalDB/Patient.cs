using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HospitalDB
{ 
    public class Patient : INotifyPropertyChanged
    {
        #region Переменные

        private string name;

        private string medicalHistory;

        private string data;

        private string startTime;

        private string finishTime;

        private string department;

        private string typeOfIntervention;

        private string typeOfService;

        private string sequela;

        private string medicalCare;

        private string priceOfService;

        private string price;

        private string code;

        private string nameDoctor;

        private string nameNurse;

        private string premedication;

        private string premedicationQuantity;

        private string opioids;

        private string opioidsQuantity;

        private string benzodiazepine;

        private string benzodiazepineQuantity;

        private string hypnotic;

        private string hypnoticQuantity;

        private string muscleRelaxant;

        private string muscleRelaxantQuantity;

        private string fluorideContaining;

        private string fluorideContainingQuantity;

        private string inhalation;

        private string timeInhalation;

        private string inhalationQuantity;

        private string opioids2;

        private string opioids2Quantity;

        private string local;

        private string localQuantity;

        private string local2;

        private string local2Quantity;

        private string neurovegetative;

        private string neurovegetativeQuantity;

        private string hemostatics;

        private string hemostaticsQuantity;

        private string antispasmodics;

        private string antispasmodicsQuantity;

        private string solutions;

        private string solutionQuantity;

        private string antropine;

        private string antropineQuantity;

        private string epudralKit;

        private string spialNeedle;

        private string typeOfSpialNeedle;

        private string endotrachealTube;

        private string points;

        #endregion
        #region Свойства
        public int Id { get; set; }
        public string Name
        {
            get { return name; }

            set
            {
                name = value;

                PropertyChangedOn("Name");
            }
        }
        public string MedicalHistory
        {
            get { return medicalHistory;  }

            set
            {
                medicalHistory = value;

                PropertyChangedOn("MedicalHistory");
            }

        }
        public string Data
        {
            get { return data; }

            set
            {
                data = value;

                PropertyChangedOn("Data");
            }
        }
        public string StartTime
        {
            get { return startTime; }

            set
            {
                startTime = value;

                PropertyChangedOn("StratTime");
            }
        }
        public string FinishTime
        {
            get { return finishTime; }

            set
            {
                finishTime = value;

                PropertyChangedOn("FinishTime");
            }
        }
        public string Department
        {
            get { return department; }

            set
            {
                department = value;

                PropertyChangedOn("Department");
            }
        }
        public string TypeOfIntervention
        {
            get { return typeOfIntervention; }

            set
            {
                typeOfIntervention = value;

                PropertyChangedOn("TypeOfIntervention");
            }
        }
        public string TypeOfService
        {
            get { return typeOfService; }

            set
            {
                typeOfService = value;

                PropertyChangedOn("TypeOfService");
            }

        }
        public string Sequela
        {
            get { return sequela; }

            set
            {
                sequela = value;

                PropertyChangedOn("Sequela");
            }
        }
        public string MedicalCare
        {
            get { return medicalCare; }

            set
            {
                medicalCare = value;

                PropertyChangedOn("MedicalCare");
            }
        }
        public string PriceOfService
        {
            get { return priceOfService; }

            set
            {
                priceOfService = value;

                PropertyChangedOn("PriceOfService");
            }
        }
        public string Price
        {
            get { return price; }

            set
            {
                price = value;

                PropertyChangedOn("Price");
            }
        }
        public string Code
        {
            get { return code; }

            set
            {
                code = value;

                PropertyChangedOn("Code");
            }
        }
        public string NameDoctor
        {
            get { return nameDoctor; }

            set
            {
                nameDoctor = value;

                PropertyChangedOn("NameDoctor");
            }
        }
        public string NameNurse
        {
            get { return nameNurse; }

            set
            {
                nameNurse = value;

                PropertyChangedOn("NameNurse");
            }
        }
        public string Premedication
        {
            get { return premedication; }

            set
            {
                premedication = value;

                PropertyChangedOn("Premedication");
            }
        }
        public string PremedicationQuantity
        {
            get { return premedicationQuantity; }

            set
            {
                premedicationQuantity = value;

                PropertyChangedOn("PremedicationQuantity");
            }
        }
        public string Opioids
        {
            get { return opioids; }

            set
            {
                opioids = value;

                PropertyChangedOn("Opioids");
            }
        }
        public string OpioidsQuantity
        {
            get { return opioidsQuantity; }

            set
            {
                opioidsQuantity = value;

                PropertyChangedOn("OpioidsQuantity");
            }
        }
        public string Benzodiazepine
        {
            get { return benzodiazepine; }

            set
            {
                benzodiazepine = value;

                PropertyChangedOn("Benzodiazepine");
            }
        }
        public string BenzodiazepineQuantity
        {
            get { return benzodiazepineQuantity; }

            set
            {
                benzodiazepineQuantity = value;

                PropertyChangedOn("BenzodiazepineQuantity");
            }
        }
        public string Hypnotic
        {
            get { return hypnotic; }

            set
            {
                hypnotic = value;

                PropertyChangedOn("Hypnotic");
            }
        }
        public string HypnoticQuantity
        {
            get { return hypnoticQuantity; }

            set
            {
                hypnoticQuantity = value;

                PropertyChangedOn("HypnoticQuantity");
            }
        }
        public string MuscleRelaxant
        {
            get { return muscleRelaxant; }

            set
            {
                muscleRelaxant = value;

                PropertyChangedOn("MuscleRelaxant");
            }
        }
        public string MuscleRelaxantQuantity
        {
            get { return muscleRelaxantQuantity; }

            set
            {
                muscleRelaxantQuantity = value;

                PropertyChangedOn("MusculeRelaxantQuantity");
            }
        }
        public string FluorideContaining
        {
            get { return fluorideContaining; }

            set
            {
                fluorideContaining = value;

                PropertyChangedOn("FluorideContaining");
            }
        }
        public string FluorideContainingQuantity
        {
            get { return fluorideContainingQuantity; }

            set
            {
                fluorideContainingQuantity = value;

                PropertyChangedOn("FluorideContainingQuantity");
            }
        }
        public string Inhalation
        {
            get { return inhalation; }

            set
            {
                inhalation = value;

                PropertyChangedOn("Inhalation");
            }
        }
        public string TimeInhalation
        {
            get { return timeInhalation; }
            
            set
            {
                timeInhalation = value;

                PropertyChangedOn("TimeInhalation");
            }
        }
        public string InhalationQuantity
        {
            get { return inhalationQuantity; }

            set
            {
                inhalationQuantity = value;

                PropertyChangedOn("InhalationQuantity");
            }
        }
        public string Opioids2
        {
            get { return opioids2; }

            set
            {
                opioids2 = value;

                PropertyChangedOn("Opioids2");
            }
        }
        public string Opioids2Quantity
        {
            get { return opioids2Quantity; }

            set
            {
                opioids2Quantity = value;

                PropertyChangedOn("Opioids2Quantity");
            }
        }
        public string Local
        {
            get { return local; }

            set
            {
                local = value;

                PropertyChangedOn("Local");
            }
        }
        public string LocalQuantity
        {
            get { return localQuantity; }

            set
            {
                localQuantity = value;

                PropertyChangedOn("LocalQuantity");
            }
        }
        public string Local2
        {
            get { return local2; }

            set
            {
                local2 = value;

                PropertyChangedOn("Local2");
            }
        }
        public string Local2Quantity
        {
            get { return local2Quantity; }

            set
            {
                local2Quantity = value;

                PropertyChangedOn("Local2Quantity");
            }
        }
        public string Neurovegetative
        {
            get { return neurovegetative; }

            set
            {
                neurovegetative = value;

                PropertyChangedOn("Neurovegetative");
            }
        }
        public string NeurovegetativeQuantity
        {
            get { return neurovegetativeQuantity; }

            set
            {
                neurovegetativeQuantity = value;

                PropertyChangedOn("NeurovegetativeQuantity");
            }
        }
        public string Hemostatics
        {
            get { return hemostatics; }

            set
            {
                hemostatics = value;

                PropertyChangedOn("Hemostatics");
            }
        }
        public string HemostaticsQuantity
        {
            get { return hemostaticsQuantity; }

            set
            {
                hemostaticsQuantity = value;

                PropertyChangedOn("HemostaticsQuantity");
            }
        }
        public string Antispasmodics
        {
            get { return antispasmodics; }

            set
            {
                antispasmodics = value;

                PropertyChangedOn("Antispasmodics");
            }
        }
        public string AntispasmodicsQuantity
        {
            get { return antispasmodicsQuantity; }

            set
            {
                antispasmodicsQuantity = value;

                PropertyChangedOn("AntispasmodicsQuantity");
            }
        }
        public string Solutions
        {
            get { return solutions; }

            set
            {
                solutions = value;

                PropertyChangedOn("Solutions");
            }
        }
        public string SolutionsQuantity
        {
            get { return solutionQuantity; }

            set
            {
                solutionQuantity = value;

                PropertyChangedOn("SolutionsQuantity");
            }
        }
        public string Antropine
        {
            get { return antropine; }

            set
            {
                antropine = value;

                PropertyChangedOn("Antropine");
            }
        }
        public string AntropineQuantity
        {
            get { return antropineQuantity; }

            set
            {
                antropineQuantity = value;

                PropertyChangedOn("AntropineQuantity");
            }
        }
        public string EpudralKit
        {
            get { return epudralKit; }

            set
            {
                epudralKit = value;

                PropertyChangedOn("EpudralKit");
            }
        }
        public string SpialNeedle
        {
            get { return spialNeedle; }

            set
            {
                spialNeedle = value;

                PropertyChangedOn("SpialNeedle");
            }
        }
        public string TypeOfSpialNeedle
        {
            get { return typeOfSpialNeedle; }
            set
            {
                typeOfSpialNeedle = value;

                PropertyChangedOn("TypeOfSpialNeedle");
            }
        }
        public string EndotrachealTube
        {
            get { return endotrachealTube; }

            set
            {
                endotrachealTube = value;

                PropertyChangedOn("EndotrachealTube");
            }
        }
        public string Points
        {
            get { return points; }

            set
            {
                points = value;

                PropertyChangedOn("Points");
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public void PropertyChangedOn([CallerMemberName]string Property = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(Property));
        }
    }
}
