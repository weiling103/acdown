﻿using System;
using System.Collections.Generic;
using System.Text;
using Kaedei.AcDown.Interface;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace Kaedei.AcDown.Interface
{
   public class TaskInfo : IXmlSerializable
   {
      public TaskInfo()
      {
         //初始化
         FilePath = new List<string>();
         SubFilePath = new List<string>();
         Settings = new SerializableDictionary<string, string>();
      }

      private Guid _taskid;
      /// <summary>
      /// 任务Id
      /// </summary>
      public Guid TaskId
      {
         get
         {
            if (_taskid == null)
               _taskid = Guid.NewGuid();
            return _taskid;
         }
         set
         {
            _taskid = value;
         }
      }


      /// <summary>
      /// Downloader所属插件名称
      /// </summary>
      public string PluginName { get; set; }

      /// <summary>
      /// Downloader所属插件
      /// </summary>
      public IAcdownPluginInfo BasePlugin { get; set; }


      private IDownloader resourceDownloader;
      /// <summary>
      /// 包装的Downloader对象
      /// </summary>
      public IDownloader Downloader { get { return resourceDownloader; } }


      /// <summary>
      /// 任务名称
      /// </summary>
      public string Title { get; set; }


      /// <summary>
      /// 下载状态
      /// </summary>
      public DownloadStatus Status { get; set; }


      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime CreateTime { get; set; }

      /// <summary>
      /// 完成时间
      /// </summary>
      public DateTime FinishTime { get; set; }


      /// <summary>
      /// 保存目录
      /// </summary>
      public DirectoryInfo SaveDirectory { get; set; }

      /// <summary>
      /// 分段总数
      /// </summary>
      public int PartCount { get; set; }

      /// <summary>
      /// 当前分段
      /// </summary>
      public int CurrentPart { get; set; }

      /// <summary>
      /// 文件列表
      /// </summary>
      public List<string> FilePath { get; set; }

      /// <summary>
      /// 子文件列表
      /// </summary>
      public List<string> SubFilePath { get; set; }


      /// <summary>
      /// 任务URL
      /// </summary>
      public string Url { get; set; }


      /// <summary>
      /// 是否下载弹幕/字幕
      /// 0-下载 1-不下载 2-只下载
      /// </summary>
      public DownloadSubtitleType DownSub { get; set; }


      /// <summary>
      /// 应用的代理服务器
      /// </summary>
      public WebProxy Proxy { get; set; }

      /// <summary>
      /// 速度限制
      /// </summary>
      public int SpeedLimit { get; set; }

      /// <summary>
      /// 引用页
      /// </summary>
      public string SourceUrl { get; set; }

      /// <summary>
      /// 注释
      /// </summary>
      public string Comment { get; set; }


      private string _hash = "";
      /// <summary>
      /// 任务的散列值
      /// </summary>
      public string Hash
      {
         get
         {
            if (BasePlugin != null)
            {
               _hash = BasePlugin.GetHash(Url);
            }
            return _hash;
         }
         set { _hash = value; }
      }

      /// <summary>
      /// 关联的UI Item
      /// </summary>
      public Object UIItem { get; set; }

      /// <summary>
      /// 插件存储的设置
      /// </summary>
      public SerializableDictionary<string, string> Settings { get; set; }

      /// <summary>
      /// 开始任务
      /// </summary>
      public void Start(DelegateContainer delegates)
      {
         if (BasePlugin == null)
            throw new Exception("未找到匹配的插件");
         resourceDownloader = BasePlugin.CreateDownloader();
         resourceDownloader.Info = this;
         resourceDownloader.delegates = delegates;
         this.Status = DownloadStatus.正在下载;
         resourceDownloader.Download();
      }

      /// <summary>
      /// 停止任务
      /// </summary>
      public void Stop()
      {
         if (resourceDownloader != null)
            resourceDownloader.StopDownload();
      }


      private double _process;
      /// <summary>
      /// 任务下载进度
      /// </summary>
      /// <returns></returns>
      public double GetProcess()
      {
         if (resourceDownloader != null)
            _process = (double)resourceDownloader.DoneBytes / (double)resourceDownloader.TotalLength;
         return _process;
      }


      /// <summary>
      /// 下载速度之差
      /// </summary>
      /// <returns></returns>
      public long GetTickCount()
      {
         if (resourceDownloader != null)
            return resourceDownloader.DoneBytes - resourceDownloader.LastTick;
         return 0;
      }

      public override string ToString()
      {
         string template = "状态:{0} ID:{1} 标题:{2} 网址:{3} 创建时间:{4} 引用页:{5} 注释:{6}";
         return string.Format(template, Status.ToString(), TaskId.ToString(), Title, Url, CreateTime.ToShortDateString(), SourceUrl, Comment);
      }

      #region IXmlSerializable 成员

      public System.Xml.Schema.XmlSchema GetSchema()
      {
         return null;
      }

      public void ReadXml(System.Xml.XmlReader reader)
      {
         XmlSerializer s = new XmlSerializer(typeof(string));
         if (reader.IsEmptyElement || !reader.Read())
         {
            return;
         }
         while (reader.NodeType != XmlNodeType.EndElement)
         {
            reader.ReadStartElement("TaskInfo");

            //taskid
            reader.ReadStartElement("TaskId");
            TaskId = new Guid((string)s.Deserialize(reader));
            reader.ReadEndElement();

            //plugin name
            reader.ReadStartElement("PluginName");
            PluginName = (string)s.Deserialize(reader);
            reader.ReadEndElement();

            //url
            reader.ReadStartElement("Url");
            Url = (string)s.Deserialize(reader);
            reader.ReadEndElement();

            //title
            reader.ReadStartElement("Title");
            Title = (string)s.Deserialize(reader);
            reader.ReadEndElement();

            //Status
            reader.ReadStartElement("Status");
            Status = (DownloadStatus)Enum.Parse(typeof(DownloadStatus), (string)s.Deserialize(reader), true);
            reader.ReadEndElement();

            //createtime
            reader.ReadStartElement("CreateTime");
            CreateTime = DateTime.Parse((string)s.Deserialize(reader));
            reader.ReadEndElement();

            //finishtime
            if (reader.IsStartElement("FinishTime"))
            {
               reader.ReadStartElement("FinishTime");
               FinishTime = DateTime.Parse((string)s.Deserialize(reader));
               reader.ReadEndElement();
            }

            //savedirectory
            reader.ReadStartElement("SaveDirectory");
            SaveDirectory = new DirectoryInfo((string)s.Deserialize(reader));
            reader.ReadEndElement();

            //partcount
            reader.ReadStartElement("PartCount");
            PartCount = Int32.Parse((string)s.Deserialize(reader));
            reader.ReadEndElement();

            //currentpart
            reader.ReadStartElement("CurrentPart");
            CurrentPart = Int32.Parse((string)s.Deserialize(reader));
            reader.ReadEndElement();

            //filepath
            reader.ReadStartElement("Files");
            FilePath = new List<string>();
            while (reader.IsStartElement("File"))
            {
               reader.ReadStartElement("File");
               FilePath.Add((string)s.Deserialize(reader));
               reader.ReadEndElement();
            }
            reader.ReadEndElement();

            //subfilepath
            reader.ReadStartElement("SubFiles");
            SubFilePath = new List<string>();
            while (reader.IsStartElement("SubFile"))
            {
               reader.ReadStartElement("SubFile");
               FilePath.Add((string)s.Deserialize(reader));
               reader.ReadEndElement();
            }
            reader.ReadEndElement();

            //downsub
            reader.ReadStartElement("DownSub");
            DownSub = (DownloadSubtitleType)Enum.Parse(typeof(DownloadSubtitleType), (string)s.Deserialize(reader), true);
            reader.ReadEndElement();

            //proxy
            XmlSerializer sProxy = new XmlSerializer(typeof(WebProxy));
            reader.ReadStartElement("Proxy");
            Proxy = (WebProxy)sProxy.Deserialize(reader);
            reader.ReadEndElement();

            //sourceUrl
            reader.ReadStartElement("SourceUrl");
            SourceUrl = (string)s.Deserialize(reader);
            reader.ReadEndElement();

            //Comment
            reader.ReadStartElement("Comment");
            Comment = (string)s.Deserialize(reader);
            reader.ReadEndElement();

            //Hash
            reader.ReadStartElement("Hash");
            _hash = (string)s.Deserialize(reader);
            reader.ReadEndElement();

            //Process
            reader.ReadStartElement("Process");
            _process = double.Parse((string)s.Deserialize(reader));
            reader.ReadEndElement();

            //settings
            XmlSerializer sSettings = new XmlSerializer(typeof(SerializableDictionary<string, string>));
            reader.ReadStartElement("Settings");
            Settings = (SerializableDictionary<string, string>)sSettings.Deserialize(reader);
            reader.ReadEndElement();


            //结束读取
            reader.ReadEndElement();
            reader.MoveToContent();
         }
         reader.ReadEndElement();
      }

      public void WriteXml(System.Xml.XmlWriter writer)
      {
         XmlSerializer s = new XmlSerializer(typeof(string));

         writer.WriteStartElement("TaskInfo");

         //taskid
         writer.WriteStartElement("TaskId");
         s.Serialize(writer, TaskId.ToString());
         writer.WriteEndElement();

         //pluginname
         writer.WriteStartElement("PluginName");
         s.Serialize(writer, PluginName);
         writer.WriteEndElement();

         //url
         writer.WriteStartElement("Url");
         s.Serialize(writer, Url);
         writer.WriteEndElement();

         //title
         writer.WriteStartElement("Title");
         s.Serialize(writer, Title);
         writer.WriteEndElement();

         //status
         writer.WriteStartElement("Status");
         s.Serialize(writer, Status.ToString());
         writer.WriteEndElement();

         //createtime
         writer.WriteStartElement("CreateTime");
         s.Serialize(writer, CreateTime.ToString());
         writer.WriteEndElement();

         //finishtime
         if (FinishTime != null)
         {
            writer.WriteStartElement("FinishTime");
            s.Serialize(writer, FinishTime.ToString());
            writer.WriteEndElement();
         }

         //savedirectory
         writer.WriteStartElement("SaveDirectory");
         s.Serialize(writer, SaveDirectory.ToString());
         writer.WriteEndElement();

         //PartCount
         writer.WriteStartElement("PartCount");
         s.Serialize(writer, PartCount.ToString());
         writer.WriteEndElement();

         //CurrentPart
         writer.WriteStartElement("CurrentPart");
         s.Serialize(writer, CurrentPart.ToString());
         writer.WriteEndElement();

         //FilePath
         writer.WriteStartElement("Files");
         foreach (string item in FilePath)
         {
            writer.WriteStartElement("File");
            s.Serialize(writer, item);
            writer.WriteEndElement();
         }
         writer.WriteEndElement();

         //SubFilePath
         writer.WriteStartElement("SubFiles");
         foreach (string item in SubFilePath)
         {
            writer.WriteStartElement("SubFile");
            s.Serialize(writer, item);
            writer.WriteEndElement();
         }
         writer.WriteEndElement();

         //DownSub
         writer.WriteStartElement("DownSub");
         s.Serialize(writer, DownSub.ToString());
         writer.WriteEndElement();

         //proxy
         XmlSerializer sProxy = new XmlSerializer(typeof(WebProxy));
         writer.WriteStartElement("Proxy");
         sProxy.Serialize(writer, Proxy);
         writer.WriteEndElement();

         //source url
         writer.WriteStartElement("SourceUrl");
         s.Serialize(writer, SourceUrl);
         writer.WriteEndElement();

         //comment
         writer.WriteStartElement("Comment");
         s.Serialize(writer, Comment);
         writer.WriteEndElement();

         //hash
         writer.WriteStartElement("Hash");
         s.Serialize(writer, Hash);
         writer.WriteEndElement();

         //process
         writer.WriteStartElement("Process");
         s.Serialize(writer, GetProcess().ToString());
         writer.WriteEndElement();

         //settings
         XmlSerializer sSettings = new XmlSerializer(typeof(SerializableDictionary<string, string>));
         writer.WriteStartElement("Settings");
         s.Serialize(writer, Settings);
         writer.WriteEndElement();

         //结束写入
         writer.WriteEndElement();

      }

      #endregion
   }

}
