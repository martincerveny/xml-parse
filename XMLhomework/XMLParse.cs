using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace XMLhomework
{
    public class XMLParse
    {
        public static bool Parse(string filePath)
        {
            try
            {
                string xmlString = File.ReadAllText(filePath);
                string cleanXml = "";
                if (!IsValidXml(xmlString))
                {
                    cleanXml = CleanInvalidXmlChars(xmlString);
                }
                
                XElement xmlTree = XElement.Parse(cleanXml);
                
                return true;
            } catch(XmlException e){
                return false;
            }
        }
        
        public static bool IsValidXml(string xml)
        {
            try
            {
                XmlConvert.VerifyXmlChars(xml);
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public static string CleanInvalidXmlChars(string text)   
        {   
            string re = @"[^\x09\x0A\x0D\x20-\xD7FF\xE000-\xFFFD\x10000-x10FFFF]";   
            return Regex.Replace(text, re, "");   
        }   
    }
}