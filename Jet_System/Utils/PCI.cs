using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using System.Windows.Forms;

namespace Jet_System.Utils
{
    public abstract class PCI
    {
        //写数据
        public const uint PCI_OUT0 = 1;//相机开始拍照信号
        public const uint PCI_OUT1 = 2;//蜂鸣器信号
        public const uint PCI_OUT2 = 4;//电缸1
        public const uint PCI_OUT3 = 8;//电缸2
        public const uint PCI_OUT4 = 16;//电缸3
        public const uint PCI_OUT5 = 32;//报警灯
        public const uint PCI_OUT6 = 64;//HOME
        public const uint PCI_OUT7 = 128;//STP，暂停
        public const uint PCI_OUT8 = 256;//RES
        public const uint PCI_OUT9 = 512;//CSTR，开始运动信号
        //读数据,比较
        public const uint PCI_IN0 = 1;//开始按钮
        public const uint PCI_IN1 = 2;//急停按钮
        public const uint PCI_IN2 = 4;//HOME ok信号
        public const uint PCI_IN3 = 8;//PEND ok信号，一次动作完成信号
        public const uint PCI_IN4 = 16;//报警信号
        public const uint PCI_IN5 = 32;//打印首个条码信号

        public static short m_dev;
        
        private static ushort PCI_name;

        private static uint PCI_data;

        public static ushort PCI_Name
        {
            set { PCI_name = value; }
            get { return PCI_name; }
        }

        public static uint PCI_Data
        {
            set { PCI_data = value; }
            get { return PCI_data; }
        }


        public  void Register()
        {
            
            m_dev = DASK.Register_Card(PCI_name, 0);
     
            if (m_dev < 0)
            {
                MessageBox.Show("Register_Card error!");
           
                System.Environment.Exit(0);
            }
        }
        public  void Release()
        {
            short ret;
            if (m_dev >= 0)
            {
                ret = DASK.Release_Card((ushort)m_dev);
            }
        }
        public  uint Read()
        {
            short ret;
            uint int_value;
            ret = DASK.DI_ReadPort((ushort)m_dev, 0, out int_value);
            if (ret < 0)
            {
             //   MessageBox.Show("D2K_DI_ReadPort error!");

                throw new ArgumentOutOfRangeException("NOT");
                return 0;
            }
            return int_value;
        }
        public  void Write(uint data)
        {
            short ret;
            
            
                ret = DASK.DO_WritePort((ushort)m_dev, 0, data);
                if (ret < 0)
                {
                   // MessageBox.Show("DO_WritePort error!");
                    return;
                }
            
        }

        public virtual void hello()
        {
            Console.WriteLine("hello world");
        }

    }


    public class PCI7230 : PCI
    {
        //构造函数
        public PCI7230()
        {
            PCI_Name = DASK.PCI_7230;   
        }

        private void WriteIO(uint dat)
        {
            try
            {
                PCI_Data |= dat;
                Write(PCI_Data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearIO(uint dat)
        {
            try
            {
                //uint s = 0;
                PCI_Data = PCI_Data & (~dat);
                Write((PCI_Data));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private bool ReadIn(uint dat)
        {
            
            uint x = Read();
            if ((x & dat) == dat)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region//IDO0
        
        public void WriteIO0()
        {
            WriteIO(PCI_OUT0);
        }

        public void ClearIO0()
        {
            ClearIO(PCI_OUT0);
        }
        #endregion



        #region//IDO1
        
        public void WriteIO1()
        {
            WriteIO(PCI_OUT1);
        }

        
        public void ClearIO1()
        {
            ClearIO(PCI_OUT1);
        }
        #endregion



        #region//IDO2
        
        public void WriteIO2()
        {
            WriteIO(PCI_OUT2);
        }

        //消除
        public void ClearIO2()
        {
            ClearIO(PCI_OUT2);
        }
        #endregion



        #region//IDO3
        //
        public void WriteIO3()
        {
            WriteIO(PCI_OUT3);
        }

        //消除
        public void ClearIO3()
        {
            ClearIO(PCI_OUT3);
        }
        #endregion



        #region//IDO4
        
        public void WriteIO4()
        {
            WriteIO(PCI_OUT4);
        }

        //消除
        public void ClearIO4()
        {
            ClearIO(PCI_OUT4);
        }
        #endregion



        #region//IDO5
        
        public void WriteIO5()
        {
            WriteIO(PCI_OUT5);
        }

        //消除
        public void ClearIO5()
        {
            ClearIO(PCI_OUT5);
        }
        #endregion


        #region//IDO6

        public void WriteIO6()
        {
            WriteIO(PCI_OUT6);
        }

        //消除
        public void ClearIO6()
        {
            ClearIO(PCI_OUT6);
        }
        #endregion

        #region//IDO7

        public void WriteIO7()
        {
            WriteIO(PCI_OUT7);
        }

        //消除
        public void ClearIO7()
        {
            ClearIO(PCI_OUT7);
        }
        #endregion

        #region//IDO8

        public void WriteIO8()
        {
            WriteIO(PCI_OUT8);
        }

        //消除
        public void ClearIO8()
        {
            ClearIO(PCI_OUT8);
        }
        #endregion


        #region//IDO9

        public void WriteIO9()
        {
            WriteIO(PCI_OUT9);
        }

        //消除
        public void ClearIO9()
        {
            ClearIO(PCI_OUT9);
        }
        #endregion



        #region//IDI0
        public bool ReadI0()
        {
            return ReadIn(PCI_IN0);
        }

        #endregion



        #region//IDI1
        public bool ReadI1()
        {
            return ReadIn(PCI_IN1);
        }

        #endregion

        #region//IDI2
        public bool ReadI2()
        {
            return ReadIn(PCI_IN2);
        }

        #endregion

        #region//IDI3
        public bool ReadI3()
        {
            return ReadIn(PCI_IN3);
        }

        #endregion

        #region//IDI4
        public bool ReadI4()
        {
            return ReadIn(PCI_IN4);
        }

        #endregion


        #region//IDI5
        public bool ReadI5()
        {
            return ReadIn(PCI_IN5);
        }

        #endregion

        #region//相机
        public void CameriaON()
        {
            WriteIO0();
        }
        public void CameriaOFF()
        {
            ClearIO0();
        }

        #endregion

        #region//两盏灯
        public void SetStartLight()
        {
            WriteIO5();
        }

        public void ClearStartLight()
        {
            ClearIO5();
        }


        public void SetBadLight()
        {
            WriteIO1();
        }

        public void ClearBadLight()
        {
            ClearIO1();
        }

        #endregion



        #region//电缸
        public void MoveLocation1()
        {
            WriteIO2();
            Thread.Sleep(200);
            StartMove();
            Thread.Sleep(200);
            ClearIO2();
            ClearIO9();
        }

        public void MoveLocation2()
        {
            WriteIO3();
            Thread.Sleep(200);
            StartMove();
            Thread.Sleep(200);
            ClearIO3();
            ClearIO9();
        }

        public void MoveLocation3()
        {
            WriteIO4();
            Thread.Sleep(200);
            StartMove();
        }

        public void MoveLocation4()
        {
            WriteIO2();
            WriteIO4();
            Thread.Sleep(200);
            StartMove();
        }


        public void StartMove()
        {
            WriteIO9();
        }
        #endregion

        #region//暂停
        public void SetPause()
        {
            WriteIO7();
        }

        public void ClearPause()
        {
            ClearIO7();
        }
        #endregion

        #region //HOME
        public void SetHome()
        {
            WriteIO6();
        }

        public void ClearHome()
        {
            ClearIO6();
        }

        #endregion

        #region//监听
        public bool ListenStartBtn()
        {
            return ReadI0();
        }

        public bool ListenScramBtn()
        {
            return ReadI1();
        }

        public bool ListenHomeOK()
        {
            return ReadI2();
        }

        public bool ListenPendOK()
        {
            return ReadI3();
        }

        public bool ListenALM()
        {
            return ReadI4();
        }

        public bool ListenPrint1()
        {
            return ReadI5();
        }

        #endregion

        #region //RES
        public void SetRES()
        {
            WriteIO8();
        }

        public void ClearRES()
        {
            ClearIO8();
        }

        #endregion


        public void Open12Light()
        {

            WriteIO(PCI_OUT0 | PCI_OUT1 );
        }

        public void Clear12Light()
        {
            ClearIO(PCI_OUT0 | PCI_OUT1 );
        }


        public void Open34Light()
        {

            WriteIO(PCI_OUT2 | PCI_OUT3);
        }

        public void Clear34Light()
        {
            ClearIO(PCI_OUT2 | PCI_OUT3);
        }

        public void Open4Light()
        {
            
            WriteIO(PCI_OUT0 | PCI_OUT1| PCI_OUT2 | PCI_OUT3);
        }

        public void Clear4Light()
        {
            ClearIO(PCI_OUT0 | PCI_OUT1 | PCI_OUT2 | PCI_OUT3);
        }

        public void Open124Light()
        {

            WriteIO(PCI_OUT0 | PCI_OUT1  | PCI_OUT3);
        }

        public void Clear124Light()
        {
            ClearIO(PCI_OUT0 | PCI_OUT1  | PCI_OUT3);
        }




        public void Init()
        {
            ClearIO0();
            ClearIO1();
            ClearIO2();
            ClearIO3();
            ClearIO4();
            ClearIO5();
            ClearIO6();
            ClearIO7();
            ClearIO8();
            ClearIO9();
        }

        


    }
}
