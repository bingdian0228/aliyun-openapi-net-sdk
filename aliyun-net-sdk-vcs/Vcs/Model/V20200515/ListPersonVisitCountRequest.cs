/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Vcs;
using Aliyun.Acs.Vcs.Transform;
using Aliyun.Acs.Vcs.Transform.V20200515;

namespace Aliyun.Acs.Vcs.Model.V20200515
{
    public class ListPersonVisitCountRequest : RpcAcsRequest<ListPersonVisitCountResponse>
    {
        public ListPersonVisitCountRequest()
            : base("Vcs", "2020-05-15", "ListPersonVisitCount")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string corpId;

		private string endTime;

		private string countType;

		private string startTime;

		private int? pageNumber;

		private string timeAggregateType;

		private int? maxVal;

		private string tagCode;

		private int? minVal;

		private int? pageSize;

		private string aggregateType;

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(BodyParameters, "EndTime", value);
			}
		}

		public string CountType
		{
			get
			{
				return countType;
			}
			set	
			{
				countType = value;
				DictionaryUtil.Add(BodyParameters, "CountType", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(BodyParameters, "StartTime", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		public string TimeAggregateType
		{
			get
			{
				return timeAggregateType;
			}
			set	
			{
				timeAggregateType = value;
				DictionaryUtil.Add(BodyParameters, "TimeAggregateType", value);
			}
		}

		public int? MaxVal
		{
			get
			{
				return maxVal;
			}
			set	
			{
				maxVal = value;
				DictionaryUtil.Add(BodyParameters, "MaxVal", value.ToString());
			}
		}

		public string TagCode
		{
			get
			{
				return tagCode;
			}
			set	
			{
				tagCode = value;
				DictionaryUtil.Add(BodyParameters, "TagCode", value);
			}
		}

		public int? MinVal
		{
			get
			{
				return minVal;
			}
			set	
			{
				minVal = value;
				DictionaryUtil.Add(BodyParameters, "MinVal", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string AggregateType
		{
			get
			{
				return aggregateType;
			}
			set	
			{
				aggregateType = value;
				DictionaryUtil.Add(BodyParameters, "AggregateType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListPersonVisitCountResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListPersonVisitCountResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
