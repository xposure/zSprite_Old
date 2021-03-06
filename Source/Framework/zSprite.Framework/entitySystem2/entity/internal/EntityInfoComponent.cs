﻿/*
 * Copyright 2013 MovingBlocks
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace org.terasology.entitySystem.entity.@internal
{

	using Replicate = org.terasology.network.Replicate;

	/// <summary>
	/// Component for storing entity system information on an entity
	/// 
	/// @author Immortius <immortius@gmail.com>
	/// </summary>
	public class EntityInfoComponent : Component
	{
		public string parentPrefab = "";
		public bool persisted = true;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @Replicate public org.terasology.entitySystem.entity.EntityRef owner = org.terasology.entitySystem.entity.EntityRef.NULL;
		public EntityRef owner = EntityRef.NULL;
		public bool alwaysRelevant;

		public EntityInfoComponent()
		{
		}

		public EntityInfoComponent(string parentPrefab, bool persisted, bool alwaysRelevant)
		{
			this.parentPrefab = parentPrefab;
			this.persisted = persisted;
			this.alwaysRelevant = alwaysRelevant;
		}
	}

}