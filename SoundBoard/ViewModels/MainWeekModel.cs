using SoundBoard.Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoard.ViewModels
{
    public class MainWeekModel : List<WeekModel>
    {
      
        public MainWeekModel()
        {
            
            LoadData();
        }

     
        public List<WeekModel> bigdataItems { get; set; }
        public List<WeekModel> pythonItems { get; set; }

        public List<WeekModel> linuxAdmItems { get; set; }
        public List<WeekModel> MachineItems { get; set; }
        public List<WeekModel> imageItems { get; set; }
        public List<WeekModel> gsmItems { get; set; }
        public List<WeekModel> javaItems { get; set; }
        public List<WeekModel> csharpItems { get; set; }
        public List<WeekModel> cplusItems { get; set; }
        public List<WeekModel> bashItems { get; set; }
        public List<WeekModel> mysqlItems { get; set; }
        public List<WeekModel> aiItems { get; set; }
        public List<WeekModel> jsItems { get; set; }
        public List<WeekModel> perlItems { get; set; }
        public List<WeekModel> phpItems { get; set; }
        public List<WeekModel> linuxnetItems { get; set; }
        public List<WeekModel> webItems { get; set; }
        public List<WeekModel> cloudItems { get; set; }
        public List<WeekModel> dataItems { get; set; }

        public void LoadData()
        {
            bigdataItems = new List<WeekModel>();
            pythonItems = new List<WeekModel>();
            linuxAdmItems = new List<WeekModel>();
            MachineItems = new List<WeekModel>();
            imageItems = new List<WeekModel>();
            gsmItems = new List<WeekModel>();
            javaItems = new List<WeekModel>();
            csharpItems = new List<WeekModel>();
            cplusItems = new List<WeekModel>();
            bashItems = new List<WeekModel>();
            mysqlItems = new List<WeekModel>();
            aiItems = new List<WeekModel>();
            jsItems = new List<WeekModel>();
            perlItems = new List<WeekModel>();
            phpItems = new List<WeekModel>();
            linuxnetItems = new List<WeekModel>();
            webItems = new List<WeekModel>();
            cloudItems = new List<WeekModel>();
            dataItems = new List<WeekModel>();

            if (MainPage.header == 0){
           
                bigdataItems.Add(new WeekModel("0", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                bigdataItems.Add(new WeekModel("1", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                bigdataItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                bigdataItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                bigdataItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                bigdataItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                bigdataItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
               
          
                pythonItems.Add(new WeekModel("0", "python one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                pythonItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                pythonItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                pythonItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                pythonItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                pythonItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                pythonItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
           
                    linuxAdmItems.Add(new WeekModel("0", "django one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    linuxAdmItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    linuxAdmItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    linuxAdmItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    linuxAdmItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    linuxAdmItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    linuxAdmItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
              
                    MachineItems.Add(new WeekModel("0", "i dont one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    MachineItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    MachineItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    MachineItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    MachineItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    MachineItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    MachineItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
               
                    imageItems.Add(new WeekModel("0", "na u aabi", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    imageItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    imageItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    imageItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    imageItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    imageItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    imageItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
              
                    gsmItems.Add(new WeekModel("0", "i dey here", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    gsmItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    gsmItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    gsmItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    gsmItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    gsmItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    gsmItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
               
                    javaItems.Add(new WeekModel("0", "cheatn", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    javaItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    javaItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    javaItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    javaItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    javaItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    javaItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                
                    csharpItems.Add(new WeekModel("0", "see this one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    csharpItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    csharpItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    csharpItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    csharpItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    csharpItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    csharpItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                
                    cplusItems.Add(new WeekModel("0", "reviw thin", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    cplusItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    cplusItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    cplusItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    cplusItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    cplusItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    cplusItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                
                    bashItems.Add(new WeekModel("0", "rubish", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    bashItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    bashItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    bashItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    bashItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    bashItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    bashItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
              
                    mysqlItems.Add(new WeekModel("0", "clean up", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    mysqlItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    mysqlItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    mysqlItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    mysqlItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    mysqlItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    mysqlItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
              
                    aiItems.Add(new WeekModel("0", "no blames", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    aiItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    aiItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    aiItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    aiItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    aiItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    aiItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
             
                    jsItems.Add(new WeekModel("0", "i love U", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    jsItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    jsItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    jsItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    jsItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    jsItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    jsItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                
                    perlItems.Add(new WeekModel("0", "C3 things", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    perlItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    perlItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    perlItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    perlItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    perlItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    perlItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
               
                    phpItems.Add(new WeekModel("0", "greatnews", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    phpItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    phpItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    phpItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    phpItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    phpItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    phpItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
               
                    linuxnetItems.Add(new WeekModel("0", "Stepping up", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    linuxnetItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    linuxnetItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    linuxnetItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    linuxnetItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    linuxnetItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    linuxnetItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
               
                    webItems.Add(new WeekModel("0", "pno time", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    webItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    webItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    webItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    webItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    webItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    webItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
               
                    cloudItems.Add(new WeekModel("0", "i hoe this works", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    cloudItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    cloudItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    cloudItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    cloudItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    cloudItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    cloudItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
             
                    dataItems.Add(new WeekModel("0", "great skill", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    dataItems.Add(new WeekModel("1", "python two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    dataItems.Add(new WeekModel("2", "runtime thre", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    dataItems.Add(new WeekModel("3", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    dataItems.Add(new WeekModel("4", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                    dataItems.Add(new WeekModel("5", "runtime two", " ccvdfcbffdmkhmgjlmbfjlkjgbmrkjmnbj  mkdjbgnjfdnhrtg  bfjnjdff"));
                    dataItems.Add(new WeekModel("6", "runtime one", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"));
                
              
            }
     
            
        }

    
    }
}
