﻿/*  OpenDiablo 2 - An open source re-implementation of Diablo 2 in C#
 *  
 *   This program is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation, either version 3 of the License, or
 *   (at your option) any later version.
 *
 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with this program.  If not, see <https://www.gnu.org/licenses/>. 
 */

using OpenDiablo2.Common.Enums;
using OpenDiablo2.Common.Models;
using OpenDiablo2.Common.Models.Mobs;
using System.Collections.Generic;
using System.IO;

namespace OpenDiablo2.Common.Interfaces
{
    public interface IMPQProvider : IEnumerable<MPQ>
    {
        IEnumerable<string> GetTextFile(string fileName);
        Stream GetStream(string fileName);
        byte[] GetBytes(string fileName);
        string GetCharacterDccPath(eHero hero, eMobMode mobMode, eCompositType compositType, PlayerEquipment equipment);
    }
}