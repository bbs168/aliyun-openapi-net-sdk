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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class UpdateHotIkDictsResponseUnmarshaller
    {
        public static UpdateHotIkDictsResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateHotIkDictsResponse updateHotIkDictsResponse = new UpdateHotIkDictsResponse();

			updateHotIkDictsResponse.HttpResponse = context.HttpResponse;
			updateHotIkDictsResponse.RequestId = context.StringValue("UpdateHotIkDicts.RequestId");

			List<UpdateHotIkDictsResponse.UpdateHotIkDicts_DictList> updateHotIkDictsResponse_result = new List<UpdateHotIkDictsResponse.UpdateHotIkDicts_DictList>();
			for (int i = 0; i < context.Length("UpdateHotIkDicts.Result.Length"); i++) {
				UpdateHotIkDictsResponse.UpdateHotIkDicts_DictList dictList = new UpdateHotIkDictsResponse.UpdateHotIkDicts_DictList();
				dictList.Name = context.StringValue("UpdateHotIkDicts.Result["+ i +"].Name");
				dictList.FileSize = context.LongValue("UpdateHotIkDicts.Result["+ i +"].FileSize");
				dictList.Type = context.StringValue("UpdateHotIkDicts.Result["+ i +"].Type");
				dictList.SourceType = context.StringValue("UpdateHotIkDicts.Result["+ i +"].SourceType");

				UpdateHotIkDictsResponse.UpdateHotIkDicts_DictList.UpdateHotIkDicts_OssObject ossObject = new UpdateHotIkDictsResponse.UpdateHotIkDicts_DictList.UpdateHotIkDicts_OssObject();
				ossObject.BucketName = context.StringValue("UpdateHotIkDicts.Result["+ i +"].OssObject.BucketName");
				ossObject.Key = context.StringValue("UpdateHotIkDicts.Result["+ i +"].OssObject.Key");
				ossObject.Etag = context.StringValue("UpdateHotIkDicts.Result["+ i +"].OssObject.Etag");
				dictList.OssObject = ossObject;

				updateHotIkDictsResponse_result.Add(dictList);
			}
			updateHotIkDictsResponse.Result = updateHotIkDictsResponse_result;
        
			return updateHotIkDictsResponse;
        }
    }
}
