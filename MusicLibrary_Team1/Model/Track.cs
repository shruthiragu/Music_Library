﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_Team1.Model
{ 
    public enum PlayListCategory
{
        Chill,
        Classics,
        Dance,
        Upbeat
    }


    public class Track
    {
        public string TrackName { get; set; }
        public string Artist { get; set; }
        public Boolean Recommendable   { get; set; }
        public PlayListCategory Category { get; set; }
        public string ImageFile { get; set; }
        public string AudioFile { get;set; }
    
        public Track(string name, PlayListCategory category)
        {
            TrackName = name;
            Category = category;
            ImageFile = $"Assets/Images/{category}/{name}.png";
            AudioFile = $"Assets/Audio/{category}/{name}.mp3";
        }

        }
    }
