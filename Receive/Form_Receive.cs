using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Receive;

namespace Receive
{
    public partial class Form_Receive : Form
    {
        public Form_Receive()
        {
            InitializeComponent();

            this.ExpressionList = new List<string>();
            this.ResultList = new List<string>();
            this.PostfixList = new List<string>();

            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.RunWorkerAsync();
        }

        //
        //
        //

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke((Action)(() => this.Reset()));
            ReceiveMSMQ(ExpressionMSMQ);
        }

        private void SendMSMQ(string queueName, string myMess)
        {
            MessageQueue messQueue = null;
            if (!MessageQueue.Exists(queueName))
            {
                messQueue = MessageQueue.Create(queueName);
            }
            else
            {
                messQueue = new MessageQueue(queueName);
            }
            messQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
            messQueue.Send(myMess);
            messQueue.Close();
        }

        private void ReceiveMSMQ(string queueName)
        {
            MessageQueue messQueue = null;
            while (!MessageQueue.Exists(queueName))
            {
            }
            messQueue = new MessageQueue(queueName);
            messQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
            messQueue.ReceiveCompleted += MessQueue_ReceiveCompleted;
            messQueue.BeginReceive();
        }

        private void MessQueue_ReceiveCompleted(object sender, ReceiveCompletedEventArgs e)
        {
            MessageQueue mq = (MessageQueue)sender;
            System.Messaging.Message m = mq.EndReceive(e.AsyncResult);
            String expression = (string)(m.Body);
            if (expression == "end")
            {
                mq.Close();
                this.Invoke((Action)(() => this.UpdatetbContent()));
                this.Invoke((Action)(() => this.HandleExpressions()));
                this.Invoke((Action)(() => this.UpdatetbPostfix()));
                this.Invoke((Action)(() => this.UpdatetbResult()));
                this.Invoke((Action)(() => {
                    foreach (string s in this.ResultList) {
                        SendMSMQ(ResultMSMQ, s);
                    }
                    SendMSMQ(ResultMSMQ, "end");
                }));
                this.Invoke((Action)(() => this.bgWorker.RunWorkerAsync()));
            }
            else
            {
                this.Invoke((Action)(() => this.ExpressionList.Add(expression)));
                mq.BeginReceive();
            }

            return;
        }

        private void HandleExpressions()
        {
            string infix = "";
            string postfix = "";
            string result = "";
            foreach (string s in this.ExpressionList)
            {
                try
                {
                    infix = s;
                    infix = PostFix.FormatExpresion(infix);
                    result = infix;
                    postfix = PostFix.InfixToPostfix(infix);
                    result += " = " + PostFix.EvaluatePostfix(postfix).ToString();
                    this.PostfixList.Add(postfix);
                    this.ResultList.Add(result);
                    
                }
                catch (Exception e)
                {
                    postfix = e.Message;
                    result += " = " + postfix;
                    this.PostfixList.Add(postfix);
                    this.ResultList.Add(result);
                }
            }
        }

        private void UpdatetbContent()
        {
            this.tbContent.Clear();
            foreach (string s in this.ExpressionList)
            {
                this.tbContent.AppendText(s);
                this.tbContent.AppendText(Environment.NewLine);
            }
        }

        private void UpdatetbPostfix()
        {
            this.tbPostfix.Clear();
            foreach (string s in this.PostfixList)
            {
                this.tbPostfix.AppendText(s);
                this.tbPostfix.AppendText(Environment.NewLine);
            }
        }

        private void UpdatetbResult()
        {
            this.tbResult.Clear();
            foreach (string s in this.ResultList)
            {
                this.tbResult.AppendText(s);
                this.tbResult.AppendText(Environment.NewLine);
            }
        }

        private void Reset()
        {
            this.ExpressionList = new List<string>();
            this.PostfixList = new List<string>();
            this.ResultList = new List<string>();
        }

        //private void HandleExpressions(string infix, ref string postfix, ref string result)
        //{
        //    PostFix.FormatExpresion(ref infix);
        //    result = infix;
        //    postfix = PostFix.InfixToPostfix(infix);
        //    result += " = " + PostFix.EvaluatePostfix(postfix).ToString();
        //}

    }
}
