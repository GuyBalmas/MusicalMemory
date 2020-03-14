using System;
using System.Media;
using static GameLogic.Enums;

namespace GameLogic
{
    public class MusicCard : Card
    {
        private eCardType m_Type;
        private string m_SongName;
        private string m_SongPath;
        private SoundPlayer m_SoundPlayer;  

        public MusicCard()
        {
            m_SongName = "";
            m_SongPath = "";
            m_SoundPlayer = null;
            m_Type = eCardType.UNDEFINED;
        }

        public MusicCard(string i_SongName)
        {
            m_SongName = i_SongName;
        }

        public string SongName {
            get { return m_SongName; }
            set { m_SongName = value; } 
        }
        
        public eCardType Type
        {
            get { return m_Type; }
            set { m_Type = value; }
        }

        public string SongPath
        {
            get {
                if (string.IsNullOrEmpty(m_SongPath))
                {
                    if (Type == eCardType.SONG)
                    {
                        m_SongPath = "Audio//" + m_SongName + "1.wav";
                    }
                    else if (Type == eCardType.SINGER)
                    {
                        m_SongPath = "Audio//" + m_SongName + "2.wav";
                    }
                    else
                    {
                        m_SongPath = "Audio//" + m_SongName + ".wav";
                    }
                }
                return m_SongPath; 
            }
        }


public void Play()
        {
            try
            {
                if (this.IsShowing && !string.IsNullOrEmpty(SongPath))
                {
                    if (m_SoundPlayer == null)
                    {
                        m_SoundPlayer = new SoundPlayer(SongPath);
                    }
                    m_SoundPlayer.Play();
                }
            }
            catch(Exception e)
            {
                // handle exception
            }
        }

        public void Stop()
        {
            try
            {
                if (this.IsShowing && !string.IsNullOrEmpty(SongPath))
                {
                    if (m_SoundPlayer == null)
                    {
                        m_SoundPlayer = new SoundPlayer(SongPath);
                    }
                    m_SoundPlayer.Stop();
                }
            }
            catch (Exception e)
            {
                // handle exception
            }
        }
    

    }


}
