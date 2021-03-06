﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab07
{
    class Crawler
    {
        private string html;
        private string url;

        public Crawler(string url)
        {
            this.url = url;
        }

        public ArrayList FindInWebSite(String regex)
        {
            ArrayList list = new ArrayList();

            using (WebClient client = new WebClient())
            {
                try
                {
                    html = client.DownloadString(url);
                    Regex r = new Regex(regex);

                    if (r.IsMatch(html))
                        foreach (Match m in r.Matches(html))
                        {
                            list.Add(m);
                        }
                }
                catch (RegexNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }

            return list;
        }

        public void ReplaceInWebsite(String regex,String regexrep)
        {
            try
            {
                Regex r = new Regex(regex);
                html = r.Replace(html, regexrep);
            }
            catch (RegexNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        public void SaveHtml()
        {
            try
            {
                StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\html.txt.");
                sw.Write(html);
                sw.Close();
            }
            catch (RegexNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        

      
       
    }
}
